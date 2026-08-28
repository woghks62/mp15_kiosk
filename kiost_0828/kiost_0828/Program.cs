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

        Menu[] menus = { amricano, coke };

        // foreach (Menu menu in menus)
        // {
        //     menu.MenuInfo();
        // }

        for (int i = 0; i < menus.Length; i++)
        {
            Console.Write($"{i+1}. ");
            menus[i].MenuInfo();
        }
        
        Console.WriteLine("----------------------------------------  ");

        Console.WriteLine($"{Name} 주문 키오스크");
        
        Console.WriteLine("----------------------------------------  ");
    }  
}