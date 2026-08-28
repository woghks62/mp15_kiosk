namespace kiost_0828;

public class Basket
{
    public Menu _menu { get; private set; }
    public int _count { get; private set; }
    
    static int sum = 0;

    public Basket(Menu menu, int count)
    {
        _menu = menu;
        _count = count;
    }
    
    public void Add(int count)
    {
        _count += count;
    }

    public int Total()
    {
        return _menu.Pay(_count);
    }

    
    public static void BasketSum(int pay)
    {
        sum+=pay;
    }

    public static void PrintBaketSum(int sum)
    {
        Console.WriteLine($"  합계 : {sum}원");
    }
}