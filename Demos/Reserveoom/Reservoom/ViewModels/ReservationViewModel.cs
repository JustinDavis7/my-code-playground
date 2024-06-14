using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.ViewModels
{
    public class ReservationViewModel : ViewModelBase //Shows how VM glue the Model, and VM together.
    {
        private readonly Reservation _reservation; // This is the Model being glued to the view.
        public string RoomID => _reservation.RoomID?.ToString(); //These are all the view items that it's gluing to.
        public string UserName => _reservation.UserName;
        public string StartDate => _reservation.StartTime.Date.ToString("d");
        public string EndDate => _reservation.EndTime.Date.ToString("d");

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
