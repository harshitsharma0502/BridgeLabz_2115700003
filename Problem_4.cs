using System;
class HotelBooking
{
    string guestName;
    int roomNumber;
    int numberOfNights;
    public HotelBooking(string guestName, int roomNumber, int numberOfNights)
    {
        this.guestName = guestName;
        this.roomNumber = roomNumber;
        this.numberOfNights = numberOfNights;
    }
    public HotelBooking(HotelBooking b)
    {
        this.guestName = b.guestName;
        this.roomNumber = b.roomNumber;
        this.numberOfNights = b.numberOfNights;

    }
    public static void Main(string[] args)
    {
        HotelBooking booking = new HotelBooking("John", 101, 5);
        HotelBooking booking2 = new HotelBooking(booking);
        Console.WriteLine("Guest Name: " + booking.guestName);
        Console.WriteLine("Guest Name: " + booking2.guestName);

    }
}