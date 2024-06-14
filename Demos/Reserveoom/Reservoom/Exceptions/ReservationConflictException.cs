using Reservoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation IncommingReservation { get; }
        public ReservationConflictException(Reservation existingReservation, Reservation incommingReservation)
        {
            ExistingReservation = existingReservation;
            IncommingReservation = incommingReservation;
        }

        public ReservationConflictException(string? message, Reservation existingReservation, Reservation incommingReservation) : base(message)
        {
            ExistingReservation = existingReservation;
            IncommingReservation = incommingReservation;
        }

        public ReservationConflictException(string? message, Exception? innerException, Reservation existingReservation, Reservation incommingReservation) : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            IncommingReservation = incommingReservation;
        }
    }
}
