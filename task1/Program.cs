public class CinemaTicket
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter movie title:");
        string movieTitle = Console.ReadLine();
        Console.WriteLine("enter number of tickets:");
        int numberOfTickets = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter price per ticket:");
        int pricePerTicket = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter movie duration (in hours):");
        double movieDuration = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter screen number:");
        int screenNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter first letter of seat row:");
        char seatRowFirstLetter = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("is movie 3D?:");
        bool is3D = Convert.ToBoolean(Console.ReadLine());

        int totalTicketCost = numberOfTickets * pricePerTicket;
        double costPerHour = pricePerTicket / movieDuration;

        Console.WriteLine($"movie title: {movieTitle}");
        Console.WriteLine($"number of tickets: {numberOfTickets}");
        Console.WriteLine($"price per ticket: {pricePerTicket}");
        Console.WriteLine($"movie duration: {movieDuration}");
        Console.WriteLine($"screen number: {screenNumber}");
        Console.WriteLine($"first letter of seat row: {seatRowFirstLetter}");
        Console.WriteLine($"is movie 3D: {is3D}");
        Console.WriteLine($"total ticket cost: {totalTicketCost}");
        Console.WriteLine($"cost per hour of movie: {costPerHour}");

        Console.WriteLine($"type of movieTitle: {movieTitle.GetType()}");
        Console.WriteLine($"type of movieDuration: {movieDuration.GetType()}");
        Console.WriteLine($"type of is3D: {is3D.GetType()}");
    }
}

