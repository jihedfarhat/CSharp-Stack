// Iterate and print values
static void PrintList(List<string> MyList)
{
    foreach (string item in MyList)
    {
        Console.WriteLine(item);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);


// Print Sum
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int num in IntList)
    {
        sum += num;
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
SumOfNumbers(TestIntList);

// Find Max
static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach (int num in IntList)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
Console.WriteLine(FindMax(TestIntList2));

// Square the Values
static List<int> SquareValues(List<int> IntList)
{
    List<int> squaredValues = new List<int>();
    foreach (int num in IntList)
    {
        squaredValues.Add(num * num);
    }
    return squaredValues;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
List<int> squaredList = SquareValues(TestIntList3);
foreach (int num in squaredList)
{
    Console.WriteLine(num);
}

// Replace Negative Numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
int[] nonNegativeArray = NonNegatives(TestIntArray);
foreach (int num in nonNegativeArray)
{
    Console.WriteLine(num);
}

// Print Dictionary
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (var pair in MyDictionary)
    {
        Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

// Find Key
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    return MyDictionary.ContainsKey(SearchTerm);
}
Console.WriteLine(FindKey(TestDict, "RealName")); // true
Console.WriteLine(FindKey(TestDict, "Name")); // false

// Generate a Dictionary
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string,int> result = new Dictionary<string,int>();
    for (int i = 0; i < Names.Count; i++)
    {
        result.Add(Names[i], Numbers[i]);
    }
    return result;
}
List<string> namesList = new List<string>() {"Julie", "Harold", "James", "Monica"};
List<int> numbersList = new List<int>() {6,12,7,10};
Dictionary<string,int> generatedDict = GenerateDictionary(namesList, numbersList);
foreach (var pair in generatedDict)
{
    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
}
