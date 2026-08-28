// https://github.com/본인계정/저장소이름

using System;
using kiost_0828;

class Program
{
    const string Name = "맥도날드";
    public static int TotalorderSum = 0;
    
    static void Main(string[] args)
    {
        Drink amricano = new("아메리카노", 10, "음료");
        Drink coke = new("콜라", 100, "음료");
        Food hamburger = new("햄버거", 200, "음식");
        Food cheeseburger = new("치즈버거", 300, "음식");
        Food chickenburger = new("치킨버거", 400, "음식");

        Menu[] menus = { hamburger, cheeseburger, chickenburger, amricano, coke,  };
        
        
        Console.WriteLine("----------------------------------------  ");

        Console.WriteLine($"{Name} 주문 키오스크");
        
        Console.WriteLine("----------------------------------------  ");
        
        for (int i = 0; i < menus.Length; i++)
        {
            Console.Write($"  {i+1}. ");
            menus[i].MenuInfo();
        }
        
        Console.WriteLine("----------------------------------------  ");
        

        // Console.WriteLine("1. 담기   2. 전체 비우기   3. 결제   4. 영업 종료");
        // Console.Write("번호 : ");
        // int choiceNumber = ConsoleInput.ReadIntInRange("", 1, 4);
        // 장바구니 정보
        
        Customer customer = new Customer();
        int menuCount=0;
        
        // switch (choiceNumber)
        // {
        //     case 1: // 담기
        //         // 메뉴 번호 수량 받아서 담기
        //         int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 6);
        //         menuCount = ConsoleInput.ReadIntInRange("수량 : ", 1, 100);
        //         customer.Add(menus[menuNumber-1],menuCount);
        //         // 장바구니 안 정보 출력
        //         Console.WriteLine("[장바구니]");
        //         customer.BascketInfo(menuCount);
        //         break;
        //     case 2:
        //         customer.Clean();
        //         break;
        //     case 3:
        //         customer.BascketInfo(menuCount);
        //         break;
        //     case 4:
        //         
        //         break;
        // }

        bool finished = false;
        while (!finished)
        {
            Console.WriteLine("1. 담기   2. 전체 비우기   3. 결제   4. 영업 종료");
            Console.Write("번호 : ");
            int choiceNumber = ConsoleInput.ReadIntInRange("", 1, 4);
            
            switch (choiceNumber)
            {
                case 1: // 담기
                    // 메뉴 번호 수량 받아서 담기
                    int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 6);
                    menuCount = ConsoleInput.ReadIntInRange("수량 : ", 1, 100);
                    customer.Add(menus[menuNumber-1],menuCount);
                    // 장바구니 안 정보 출력
                    Console.WriteLine("[장바구니]");
                    customer.BascketInfo(menuCount);
                    break;
                case 2:
                    customer.Clean();
                    break;
                case 3:
                    customer.BascketInfo(menuCount);
                    int paid = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);
                    Console.WriteLine(Customer.sum);
                    if (paid >= Customer.sum)
                    {
                        Console.WriteLine($"거스름돈 : {paid - Customer.sum}");
                        TotalorderSum += Customer.sum;
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다.");
                    }
                    break;
                case 4:
                    Console.WriteLine($"총 주문 건수: {Customer.Totalorder}");
                    Console.WriteLine($"매출액 : {TotalorderSum}");
                    finished = true;
                    break;
            }
        }
        
        
        
        
        
        
        
        
        
        
        
        // Console.WriteLine("----------------------------------------  ");
        // Console.WriteLine("1. 담기   2. 전체 비우기   3. 결제   4. 영업 종료");
        // Console.Write("번호 : ");
        //int choiceNumber = ConsoleInput.ReadIntInRange("", 1, 4);
        
        


        // // 1부터 6 사이의 번호를 받습니다. 숫자가 아니거나 범위를 벗어나면 다시 묻습니다.  
        // int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 6);
        //
        // // 0 이상의 값을 받습니다. 위쪽 한계를 정하기 어려울 때 씁니다.  
        // int paid = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);
        //
        // // 결과를 보여 준 뒤 화면을 지우기 전에 잠시 멈춥니다.  
        // ConsoleInput.Pause();

    }  
    
    
}

