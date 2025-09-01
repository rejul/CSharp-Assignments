namespace ClassAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a MovieTicket class to manage ticket sales. 
            //  Fields: movieName (string), totalSeats (int), bookedSeats (int) 
            //  Methods: 
            //  BookSeats(int seats) (only if seats available) 
            //  CancelSeats(int seats) (cannot cancel more than booked) 
            //  Override ToString() to show booking status.
            Console.WriteLine("----Movie Ticket----");
            Model.MovieTicket ticket = new Model.MovieTicket();
            Console.WriteLine("Enter the Movie Name");
            ticket.MovieName = Console.ReadLine();
            Console.WriteLine("Enter the Total Seats");
            ticket.TotalSeats = Convert.ToInt32(Console.ReadLine());
            ticket.BookedSeats = 0;
            Console.WriteLine("-----BOOK THE SEAT---");
            Console.WriteLine("Enter the number of seats to book");
            int seatsToBook = Convert.ToInt32(Console.ReadLine());
            ticket.BookSeats(seatsToBook);
            Console.WriteLine(ticket);
            Console.WriteLine("-----CANCEL THE SEAT---");
            Console.WriteLine("Enter the number of seats to cancel");
            int seatsToCancel = Convert.ToInt32(Console.ReadLine());
            ticket.CancelSeats(seatsToCancel);
            Console.WriteLine(ticket);

        }
    }
}
