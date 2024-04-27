// Define the Player class
public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public List<string> Attacks { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100; // Default health
        Attacks = new List<string> { "Attack1", "Attack2", "Attack3", "Attack4" }; // Add your own attacks
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the game!");

        // Get player's name
        Console.Write("Enter your character's name: ");
        string playerName = Console.ReadLine();
        Player player = new Player(playerName);

        // Set up enemy
        // You can randomly select an enemy or default to a specific one

        // Start the game loop
        bool continueGame = true;
        while (continueGame)
        {
            // Start a new round of combat
            Console.WriteLine($"You are fighting against the enemy!");

            while (player.Health > 0 && enemy.Health > 0)
            {
                // Player's turn
                // Display available attacks and prompt for player's choice
                // Reduce enemy's health based on player's attack

                // Enemy's turn
                // Randomly select an attack for the enemy
                // Reduce player's health based on enemy's attack
            }

            // Declare the winner and prompt to continue
            if (player.Health <= 0)
            {
                Console.WriteLine("You lost! Do you want to play again? (yes/no)");
            }
            else
            {
                Console.WriteLine("You won! Do you want to play again? (yes/no)");
            }

            string response = Console.ReadLine();
            if (response.ToLower() != "yes")
            {
                continueGame = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
