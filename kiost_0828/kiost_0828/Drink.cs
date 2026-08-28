namespace kiost_0828;

public class Drink : Menu
{
    private const string Price_criteria = "3개 이상 10% 할인";
    private const float sale = 0.9f;
    
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
        if (count >= 3)
        {
            return (int)((count*Price)*sale);
        }
        else
        {
            return count * Price;
        }
    }
}