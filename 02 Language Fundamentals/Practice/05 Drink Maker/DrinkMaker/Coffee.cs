public class Coffee : Drink
{
    public string Roast;
    public string BeanType;

    public Coffee(string name, string color, double temp, bool isCarb, int calories, string roast, string beanType)
        : base(name, color, temp, isCarb, calories)
    {
        Roast = roast;
        BeanType = beanType;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Roast: {Roast}, Bean Type: {BeanType}");
    }
}
