namespace kiost_0828;

public abstract class Menu
{
    public virtual string Name { get; set; }
    protected int Price { get; set; }
    protected string Type { get; set; }
    
    public Menu(string name, int price, string type)
    {
        Name = name;
        Price = price;
        Type = type;
    }

    public virtual void MenuInfo()
    {
        Console.WriteLine($"{Name} - {Price} - {Type}");
    }

    public abstract int Pay(int num);
}