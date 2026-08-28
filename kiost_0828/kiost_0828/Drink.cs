namespace kiost_0828;

public class Drink : Menu
{
    public Drink(string name, int price, string type)
        : base(name, price, type)
    {
        
    }

    public override void MenuInfo()
    {
        Console.WriteLine($"{Name} ({Type}) {Price}원 ");
    }
}