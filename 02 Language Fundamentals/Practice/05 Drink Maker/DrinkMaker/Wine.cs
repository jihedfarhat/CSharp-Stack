public class Wine : Drink
{
    public string Region;
    public int YearBottled;

    public Wine(string name, string color, double temp, bool isCarb, int calories, string region, int yearBottled)
        : base(name, color, temp, isCarb, calories)
    {
        Region = region;
        YearBottled = yearBottled;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Region: {Region}, Year Bottled: {YearBottled}");
    }
}
