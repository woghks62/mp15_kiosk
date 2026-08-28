namespace kiost_0828;

public class Customer
{
   public int Id { get; set; }
   public int count { get; set; }
   
   private List<Basket> list = new List<Basket>();

   public void Clean()
   {
      list.Clear();
   }

   public void Add(Menu menu,int count)
   {
      for (int i = 0; i < list.Count; i++)
      {
         if (list[i]._menu == menu)
         {
            list[i].Add(count);
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
      for (int i = 0; i < list.Count; i++)
      {
         Console.WriteLine($"  {list[i]._menu.Name} x{count}  {list[i].Total()}원");
         Basket.BasketSum(list[i].Total());

      }
   }
   
   //list[i]._menu.Pay(10)
   // 리스트번째 메뉴의 갯수의 가격
   
   
   public void End()
   {
      Console.WriteLine(list.Count);
   }
}