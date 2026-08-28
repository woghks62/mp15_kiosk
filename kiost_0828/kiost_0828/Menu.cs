namespace kiost_0828;

public class Menu
{
    protected virtual string Name { get; set; }
    protected int Price { get; set; }
    protected string Type { get; set; }
    
    public Menu(string name, int price, string type)
    {
        Name = name;
        Price = price;
        Type = type;
    }
    
}