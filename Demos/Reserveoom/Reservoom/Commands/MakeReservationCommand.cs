﻿using Reservoom.Exceptions;
using Reservoom.Models;
using Reservoom.Services;
using Reservoom.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservoom.Commands
{
    public class MakeReservationCommand : AsyncCommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        private readonly NavigationService _reservationViewNavigationService;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel, NavigationService reservationViewNavigationService)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _reservationViewNavigationService = reservationViewNavigationService;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged; // Need to do this so that the submit button can be active again.
        }

        public override bool CanExecute(object parameter) // Doing this makes the Submit button greyed out and unclickable until something is in the name box.
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) && 
                _makeReservationViewModel.FloorNumber > 0 &&
                base.CanExecute(parameter);
        }
        public override async Task ExecuteAsync(object parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate);

            try
            {
                await _hotel.MakeReservation(reservation); 
                MessageBox.Show("Succesfully reserved room.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                _reservationViewNavigationService.Navigate();
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show("This room is already taken.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to make reservation.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
              
        }
        
        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(MakeReservationViewModel.Username) ||
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
            {
                OnCanExecuteChanged();
            }
        }
    }
}
