namespace kiost_0828;

public class Drink : Menu
{
    private const string Price_criteria = "음식 사면 50% 할인";
    private const float sale = 0.5f;
    
    public Drink(string name, int price, string type)
        : base(name, price, type)
    {
        
    }

    public override void MenuInfo()
    {
        Console.WriteLine($"{Name} ({Type}) {Price}원 [{Price_criteria}]");
    }
    
    public override int Pay(int count)
    {
        return 0;
    }
}