using Reservations.Entities.Exceptions;
using System;

namespace Reservations.Entities
{
    class Reservation
    {
        //Properties 
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        //Constructors 
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkin > checkout)
            {
                throw new DomainException("Check-in date can´t be posterior to chec-out date.");
            }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return duration.Days;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                throw new DomainException("You can´t update a reservation with inferior dates.");
            }
            if (checkin > checkout)
            {
                throw new DomainException("Check-in date can´t be posterior to chec-out date.");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Reservation: Room "
                +   RoomNumber
                +   ", check-in: "
                +   Checkin.ToString("dd/MM/yyyy")
                +   ", check-out: "
                +   Checkout.ToString("dd/MM/yyyy")
                +   $", {Duration()} nights";
        }

    }
}
