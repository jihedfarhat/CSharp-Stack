// Three Basic Arrays
int[] numbers = new int[10];
for (int i = 0; i < 10; i++)
{
  numbers[i] = i;
}

string[] names = { "Tim", "Martin", "Nikki", "Sara" };

bool[] alternating = new bool[10];
for (int i = 0; i < 10; i++)
{
  alternating[i] = i % 2 == 0;
}

// List of Flavors
List<string> flavors = new List<string>();
flavors.Add("Vanilla");
flavors.Add("Chocolate");
flavors.Add("Strawberry");
flavors.Add("Mint");
flavors.Add("Cookie Dough");

Console.WriteLine("Length of flavors list: " + flavors.Count);
Console.WriteLine("Third flavor: " + flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine("Length after removing third flavor: " + flavors.Count);
