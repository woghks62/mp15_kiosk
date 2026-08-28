namespace kiost_0828;

public class Customer
{
   public int Id { get; set; }
   public int count { get; set; }
   
   private List<Basket> list = new List<Basket>();

   private static int sum = 0;

   public void Clean()
   {
      list.Clear();
      Console.WriteLine("장바구니 전체 비우기 성공");
   }

   public void Add(Menu menu,int count)   // 주문한 음식과 개수
   {
      for (int i = 0; i < list.Count; i++)   // 장바구니 카운트까지 돌아
      {
         if (list[i]._menu == menu)       //리스트i의 메뉴가 주문한 음식과 같으면
         {
            list[i].Add(count);         //
            return;
         }
      }
      list.Add(new Basket(menu, count));
   }

   public void Pay()
   {
      foreach (Basket b in list)
      {
         b.Total();
      }
   }



   public void BascketInfo(int count)
   {
      sum = 0;
      if (count <= 0)
      {
         Console.WriteLine("장바구니가 비어있습니다.");
      }
      
      for (int i = 0; i < list.Count; i++)
      {
         Console.WriteLine($"  {list[i]._menu.Name} x{list[i]._count}  {list[i].Total()}원");
         sum += list[i].Total();
         //Basket.BasketSum(count*list[i]._menu.Price);
      }
      Basket.PrintBaketSum(sum);
   }
   
   //list[i]._menu.Pay(10)
   // 리스트번째 메뉴의 갯수의 가격
   
   
   public void End()
   {
      Console.WriteLine(list.Count);
   }
}