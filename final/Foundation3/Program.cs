using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Tinus de Jongh Street", "Johannesburg", "Gauteng", "South Africa");
        address1.FullAddress();

        Lecture lecture = new Lecture("Dr. Lingard", 400, "Basics of Quantum Physics", "The purpose of this event is to help students become comfortable with the most primitive principles of Quantum Physics", "25 June 2023", "08:00 - 12:30", address1.FullAddress());
        Console.WriteLine($"Standard Details:\n{lecture.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details:\n{lecture.FullDetails("Lecture", $"Speaker: {lecture.GetSpeaker()}\nCapacity: {lecture.GetCapacityLimit()} people")}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{lecture.ShortDescription("Lecture")}");

        Console.WriteLine();
        Console.WriteLine();

        Address address2 = new Address("Strand Street", "Cape Town", "Western Cape", "South Africa");
        address2.FullAddress();

        Reception reception = new Reception("james.petersen@gmail.com", "Sarah & James' Wedding Reception", "You are invited to Sarah & James' beautiful wedding reception. We look forward to seeing you there. Please RSVP at the email provided below", "27 September 2023", "10:00 - 16:00", address2.FullAddress());
        Console.WriteLine($"Standard Details:\n{reception.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details:\n{reception.FullDetails("Reception", $"To RSVP, send an email to {reception.GetRSVPEmail()}")}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{reception.ShortDescription("Reception")}");

        Console.WriteLine();
        Console.WriteLine();

        Address address3 = new Address("Anton Lembede Street", "Durban", "Kwa-Zulu Natal", "South Africa");
        address3.FullAddress();

        Outdoor outdoor = new Outdoor("Overcast", "Strictly Soul Durban", "South Africa's biggest R&B party is back in Durban! If you're a lover of Soul music then we got the perfect link up for you. We've dedicated a full night to Rihanna, Beyonce, TLC, Mary J Blige, Trey Songz, and Summer Walker.", "31 March 2023", "19:00 - 01:00", address3.FullAddress());
        Console.WriteLine($"Standard Details:\n{outdoor.StandardDetails()}");
        Console.WriteLine();
        Console.WriteLine($"Full Details:\n{outdoor.FullDetails("Outdoor", $"The weather will be {outdoor.GetWeatherConditions()}")}");
        Console.WriteLine();
        Console.WriteLine($"Short Description:\n{outdoor.ShortDescription("Outdoor")}");



        
    }
}