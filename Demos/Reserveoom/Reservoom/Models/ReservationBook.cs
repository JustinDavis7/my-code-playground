using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class ReservationBook
    {
        private readonly Dictionary<RoomID, List<Reservation>> _roomsToReservations;

        public ReservationBook()
        {
            _roomsToReservations = new Dictionary<RoomID, List<Reservation>>();
        }
    }
}
