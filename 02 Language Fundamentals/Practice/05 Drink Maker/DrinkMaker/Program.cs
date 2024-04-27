
        Drink water = new Drink("Water", "Clear", 5.0, false, 0);
        Soda coke = new Soda("Coke", "Brown", 5.0, true, 140, false);
        Coffee espresso = new Coffee("Espresso", "Brown", 70.0, false, 5, "Dark", "Arabica");
        Wine chardonnay = new Wine("Chardonnay", "Yellow", 55.0, false, 120, "Napa Valley", 2024);

        List<Drink> allBeverages = new List<Drink>();
        allBeverages.Add(water);
        allBeverages.Add(coke);
        allBeverages.Add(espresso);
        allBeverages.Add(chardonnay);

        Console.WriteLine("Before Override:");
        foreach (Drink drink in allBeverages)
        {
            drink.ShowDrink();
            Console.WriteLine();
        }

        Console.WriteLine("\nAfter Override:");
        foreach (Drink drink in allBeverages)
        {
            drink.ShowDrink();
            Console.WriteLine();
        }

