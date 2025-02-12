using System;

public class Ticket
{
    public int ticketId;
    public string customerName;
    public string movieName;
    public int seatNumber;
    public DateTime bookingTime;
    public Ticket next;

    public Ticket(int ticketId, string customerName, string movieName, int seatNumber)
    {
        this.ticketId = ticketId;
        this.customerName = customerName;
        this.movieName = movieName;
        this.seatNumber = seatNumber;
        this.bookingTime = DateTime.Now;
        this.next = null;
    }
}

public class TicketReservationSystem
{
    private Ticket head = null;
    private Ticket tail = null;

    public void AddTicket(int ticketId, string customerName, string movieName, int seatNumber)
    {
        Ticket newTicket = new Ticket(ticketId, customerName, movieName, seatNumber);

        if (head == null)
        {
            head = tail = newTicket;
            tail.next = head;
        }
        else
        {
            tail.next = newTicket;
            tail = newTicket;
            tail.next = head;
        }

        Console.WriteLine($"Ticket {ticketId} booked successfully for {customerName}.");
    }

    public void RemoveTicket(int ticketId)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets to remove.");
            return;
        }

        Ticket temp = head, prev = null;


        if (head.ticketId == ticketId)
        {
            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.next;
                tail.next = head;
            }
            Console.WriteLine($"Ticket {ticketId} canceled successfully.");
            return;
        }

        do
        {
            prev = temp;
            temp = temp.next;

            if (temp.ticketId == ticketId)
            {
                prev.next = temp.next;
                if (temp == tail)
                    tail = prev;
                Console.WriteLine($"Ticket {ticketId} canceled successfully.");
                return;
            }
        } while (temp != head);

        Console.WriteLine($"Ticket {ticketId} not found.");
    }

    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked.");
            return;
        }

        Ticket temp = head;
        Console.WriteLine("\nCurrent Booked Tickets:");
        do
        {
            Console.WriteLine($"Ticket ID: {temp.ticketId}, Customer: {temp.customerName}, Movie: {temp.movieName}, Seat: {temp.seatNumber}, Booking Time: {temp.bookingTime}");
            temp = temp.next;
        } while (temp != head);
    }

    public void SearchTicket(string searchTerm)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets found.");
            return;
        }

        Ticket temp = head;
        bool found = false;
        Console.WriteLine($"\nSearching for tickets with '{searchTerm}':");

        do
        {
            if (temp.customerName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                temp.movieName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Ticket ID: {temp.ticketId}, Customer: {temp.customerName}, Movie: {temp.movieName}, Seat: {temp.seatNumber}, Booking Time: {temp.bookingTime}");
                found = true;
            }
            temp = temp.next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("No matching tickets found.");
    }


    public int CountTotalTickets()
    {
        if (head == null) return 0;

        int count = 0;
        Ticket temp = head;
        do
        {
            count++;
            temp = temp.next;
        } while (temp != head);

        return count;
    }
}


class Program
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();

        system.AddTicket(101, "Alice", "Inception", 12);
        system.AddTicket(102, "Bob", "Interstellar", 8);
        system.AddTicket(103, "Charlie", "Tenet", 15);

        system.DisplayTickets();

        system.SearchTicket("Alice");
        system.SearchTicket("Tenet");

        Console.WriteLine($"\nTotal Booked Tickets: {system.CountTotalTickets()}");

        system.RemoveTicket(102);

        system.DisplayTickets();

        Console.WriteLine($"\nTotal Booked Tickets: {system.CountTotalTickets()}");
    }
}
