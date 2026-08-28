// https://github.com/본인계정/저장소이름

using System;
using kiost_0828;

class Program
{
    const string Name = "맥도날드";
    
    static void Main(string[] args)
    {
        Drink amricano = new("아메리카노", 10, "음료");
        Drink coke = new("콜라", 100, "음료");
        Food hamburger = new("햄버거", 200, "음식");
        Food cheeseburger = new("치즈버거", 300, "음식");
        Food chickenburger = new("치즈버거", 400, "음식");

        Menu[] menus = { amricano, coke, hamburger, cheeseburger, chickenburger };


        
        
        Console.WriteLine("----------------------------------------  ");

        Console.WriteLine($"{Name} 주문 키오스크");
        
        Console.WriteLine("----------------------------------------  ");
        
        for (int i = 0; i < menus.Length; i++)
        {
            Console.Write($"  {i+1}. ");
            menus[i].MenuInfo();
        }
        
        Console.WriteLine("----------------------------------------  ");
        
        Console.WriteLine("[장바구니]");
        
    }  
}