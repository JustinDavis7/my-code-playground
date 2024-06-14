using Reservoom.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Reservoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Singleston Suites");

            hotel.MakeReservation(new Reservation(
                new RoomID(1, 3),
                "Singleton",
                new DateTime(2000, 1, 1),
                new DateTime(2000, 1, 2)));

            hotel.MakeReservation(new Reservation(
                new RoomID(1, 2),
                "Singleton",
                new DateTime(2000, 1, 3),
                new DateTime(2000, 1, 4)));

            IEnumerable<Reservation> reservations = hotel.GetAllReservations();

            base.OnStartup(e);
        }
    }

}
