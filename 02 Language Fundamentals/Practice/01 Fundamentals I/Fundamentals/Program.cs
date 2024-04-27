// Exercise 1: Print values from 1 to 255
for (int i = 1; i <= 255; i++)
{
  Console.WriteLine(i);
}

// Exercise 2: Generate 5 random numbers between 10 and 20
Random random = new Random();
for (int i = 0; i < 5; i++)
{
  int randomNumber = random.Next(10, 21); 
  Console.WriteLine($"Random Number {i + 1}: {randomNumber}");
}
// Exercise 3: Add random values together and print the sum
int sum = 0;
for (int i = 0; i < 5; i++)
{
  int randomNumber = random.Next(10, 21);
  sum += randomNumber;
}
Console.WriteLine($"Sum of random numbers: {sum}");

// Exercise 4: Print values from 1 to 100 that are divisible by 3 OR 5, but NOT both

for (int i = 1; i <= 100; i++)
{
  if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
  {
    Console.WriteLine(i);
  }
}

// Exercise 5: Print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for multiples of both

for (int i = 1; i <= 100; i++)
{
  if (i % 3 == 0 && i % 5 == 0)
  {
    Console.WriteLine("FizzBuzz");
  }
  else if (i % 3 == 0)
  {
    Console.WriteLine("Fizz");
  }
  if (i % 5 == 0)
  {
    Console.WriteLine("Buzz");
  }
}
