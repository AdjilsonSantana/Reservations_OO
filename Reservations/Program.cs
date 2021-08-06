using System;
using Reservations.Entities.Exceptions;
using Reservations.Entities;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation r = new Reservation(room, checkin, checkout);
                Console.WriteLine();
                Console.WriteLine(r);
                Console.WriteLine();

                Console.WriteLine("Enter a data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());
                r.UpdateDates(checkin,checkout);
                Console.WriteLine();
                Console.WriteLine(r);

            }
            catch(DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please insert caractere accordindly with what was asked.");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
