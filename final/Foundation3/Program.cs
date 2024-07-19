using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "62701");
        Address address2 = new Address("456 Oak St", "Dayton", "OH", "45402");
        Address address3 = new Address("789 Pine St", "Dover", "DE", "19901");

        Lecture lecture = new Lecture("AI and the Future", "A talk on AI trends", "2024-08-01", "10:00 AM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Networking Event", "Meet industry leaders", "2024-08-10", "06:00 PM", address2, "rsvp@event.com");
        OutdoorGathering outdoor = new OutdoorGathering("Community Picnic", "Annual picnic for the community", "2024-08-15", "12:00 PM", address3, "Sunny");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event eventItem in events)
        {
            Console.WriteLine("Standard Details:\n" + eventItem.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n" + eventItem.GetFullDetails());
            Console.WriteLine("\nShort Description:\n" + eventItem.GetShortDescription());
            Console.WriteLine("\n" + new string('-', 50) + "\n");
        }
    }
}
