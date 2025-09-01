using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment3.Model
{
    public class MovieTicket
    {

        //Create a MovieTicket class to manage ticket sales. 
        //  Fields: movieName (string), totalSeats (int), bookedSeats (int) 
        //  Methods: 
        //  BookSeats(int seats) (only if seats available) 
        //  CancelSeats(int seats) (cannot cancel more than booked) 
        //  Override ToString() to show booking status.

        public string MovieName { get; set; }
        public int TotalSeats { get; set; }
        public int BookedSeats { get; set; }
        public MovieTicket()
        {
        }
        public bool BookSeats(int seats)
        {
            if (seats <= 0)
            {
                Console.WriteLine("Number of seats to book must be greater than zero.");
                return false;
            }
            if (BookedSeats + seats <= TotalSeats)
            {
                BookedSeats += seats;
                return true;
            }
            else
            {
                Console.WriteLine("Not enough seats available.");
                return false;
            }
        }

        public bool CancelSeats(int seats)
        {
            if (seats <= 0)
            {
                Console.WriteLine("Number of seats to cancel must be greater than zero.");
                return false;
            }
            if (seats <= BookedSeats)
            {
                BookedSeats -= seats;
                return true;
            }
            else
            {
                Console.WriteLine("Cannot cancel more seats than booked.");
                return false;
            }
        }
        public override string ToString()
        {
            return $"Movie Name: {MovieName}, Total Seats: {TotalSeats}, Booked Seats: {BookedSeats}, Available Seats: {TotalSeats - BookedSeats}";
        }
    }
}
