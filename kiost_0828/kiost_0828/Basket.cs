namespace kiost_0828;

public class Basket
{
    public Menu _menu { get; set; }
    protected int _count { get; set; }

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
}