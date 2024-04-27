// Coin Flip
static string CoinFlip()
{
    Random rand = new Random();
    int result = rand.Next(2); // Generates a random number (0 or 1)
    if (result == 0)
    {
        return "Heads";
    }
    else
    {
        return "Tails";
    }
}

// Dice Roll
static int DiceRoll()
{
    Random rand = new Random();
    return rand.Next(1, 7); // Generates a random number between 1 and 6 (inclusive)
}

// Stat Roll
static List<int> StatRoll()
{
    List<int> rolls = new List<int>();
    for (int i = 0; i < 4; i++)
    {
        rolls.Add(DiceRoll());
    }
    return rolls;
}

// Roll Until...
static string RollUntil(int target)
{
    int count = 0;
    while (true)
    {
        int result = DiceRoll();
        count++;
        if (result == target)
        {
            return $"Rolled a {target} after {count} tries";
        }
    }
}

// Optional Bonus: Interactive Dice Roller
static void Main(string[] args)
{
    while (true)
    {
        Console.WriteLine("Choose a function to run:");
        Console.WriteLine("1. Coin Flip");
        Console.WriteLine("2. Dice Roll");
        Console.WriteLine("3. Stat Roll");
        Console.WriteLine("4. Roll Until...");
        Console.WriteLine("5. Exit");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine(CoinFlip());
                break;
            case 2:
                Console.WriteLine(DiceRoll());
                break;
            case 3:
                List<int> stats = StatRoll();
                Console.WriteLine("Results of 4 dice rolls:");
                foreach (int roll in stats)
                {
                    Console.WriteLine(roll);
                }
                Console.WriteLine($"Largest value rolled: {stats.Max()}");
                break;
            case 4:
                Console.WriteLine("Enter the number to roll until:");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine(RollUntil(target));
                break;
            case 5:
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}

