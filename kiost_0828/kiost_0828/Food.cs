namespace kiost_0828;

public class Food : Menu
{
    private const string Price_criteria = "정가";
    
    public Food(string name, int price, string type)
        : base(name, price, type)
    {
        
    }

    public override void MenuInfo()
    {
        Console.WriteLine($"{Name} ({Type}) {Price}원 [{Price_criteria}] ");
    }

    public override int Pay(int count)
    {
        return Price * count;
    }
}