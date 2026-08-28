namespace kiost_0828;

public class Basket
{
    protected string _name { get; set; }
    protected int _count { get; set; }

    public Basket(string name, int count)
    {
        _name = name;
        _count = count;
    }
    
    public void Add(string name, int count)
    {
        _count += count;
    }

    public void Total()
    {
        
    }
}