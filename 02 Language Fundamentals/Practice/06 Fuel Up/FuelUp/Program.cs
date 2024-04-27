

public abstract class Vehicle
{
    public string Name { get; set; }
    public int FuelTotal { get; set; }

    protected Vehicle(string name)
    {
        Name = name;
        FuelTotal = 10; 
    }
}

public class Car : Vehicle, INeedFuel
{
    public string FuelType { get; set; }

    public Car(string name) : base(name)
    {
        FuelType = "gas";
    }

    public void GiveFuel(int amount)
    {
        FuelTotal += amount;
    }
}

public class Horse : Vehicle, INeedFuel
{
    public string FuelType { get; set; }

    public Horse(string name) : base(name)
    {
        FuelType = "hay";
    }

    public void GiveFuel(int amount)
    {
        FuelTotal += amount;
    }
}

public class Bicycle : Vehicle
{
    public Bicycle(string name) : base(name) { }
}


public interface INeedFuel
{
    string FuelType { get; set; }
    void GiveFuel(int amount);
}


        Car car = new Car("Car");
        Horse horse = new Horse("Horse");
        Bicycle bicycle = new Bicycle("Bicycle");


        List<Vehicle> vehicles = new List<Vehicle> { car, horse, bicycle };

        List<INeedFuel> vehiclesWithFuel = new List<INeedFuel>();

        foreach (var vehicle in vehicles)
        {
            if (vehicle is INeedFuel)
            {
                vehiclesWithFuel.Add((INeedFuel)vehicle);
            }
        }

        foreach (var vehicle in vehiclesWithFuel)
        {
            vehicle.GiveFuel(10);
        }

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"{vehicle.Name}: {vehicle.FuelTotal} units of {((INeedFuel)vehicle).FuelType} fuel");
        }

