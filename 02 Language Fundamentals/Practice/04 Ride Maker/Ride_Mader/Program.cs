

class Program
{
    static void Main()
    {
        Vehicle car1 = new Vehicle("Honda Accord", 5, "Red", true);
        Vehicle car2 = new Vehicle("Toyota Camry", "Blue");
        Vehicle bike = new Vehicle("Mountain Bike", 1, "Black", false);
        Vehicle skateboard = new Vehicle("Skateboard", "Purple");

        List<Vehicle> vehicles = new List<Vehicle> { car1, car2, bike, skateboard };

        foreach (var vehicle in vehicles)
        {
            vehicle.ShowInfo();
            Console.WriteLine();
        }

        car1.Travel(100);

        Console.WriteLine("\nAfter traveling 100 miles:");
        car1.ShowInfo();
    }
}
