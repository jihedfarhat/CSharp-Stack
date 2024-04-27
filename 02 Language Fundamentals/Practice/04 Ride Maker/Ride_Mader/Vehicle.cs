

public class Vehicle
{
    // Fields
    private string name;
    private int passengers;
    private string color;
    private bool hasEngine;
    private int distanceTraveled;

    // Constructors
    public Vehicle(string name, int passengers, string color, bool hasEngine)
    {
        this.name = name;
        this.passengers = passengers;
        this.color = color;
        this.hasEngine = hasEngine;
        this.distanceTraveled = 0;
    }

    public Vehicle(string name, string color)
    {
        this.name = name;
        this.color = color;
        this.passengers = 4; 
        this.hasEngine = true; 
        this.distanceTraveled = 0;
    }

    // Methods
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Passengers: {passengers}");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Has Engine: {(hasEngine ? "Yes" : "No")}");
        Console.WriteLine($"Distance Traveled: {distanceTraveled} miles");
    }

    public void Travel(int distance)
    {
        distanceTraveled += distance;
        Console.WriteLine($"The vehicle has traveled {distance} miles.");
    }
}
