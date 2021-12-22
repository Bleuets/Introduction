using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //

            Item item1 = new Item();
            item1.Id = 1;
            item1.CatId = 1;
            item1.ItemName = "Item Number 1";
            item1.ItemUnitPrice = 100;
            item1.ItemInStock = 10;

            Item item2 = new Item { 
                Id = 2, 
                CatId = 2, 
                ItemName = "Item Number 2",
                ItemUnitPrice = 200,
                ItemInStock = 20,
            };

            //PascalCase //camelCase
            ItemManager itemManager = new ItemManager();
            itemManager.Add(item1); //ItemManager.Add'a "item" gönderir.



            //"ref/out"

            //SumIt0 ve SumIt1 farkını incele.
            //itemManager.SumIt1(10, 10); //20

            //int sumItTotal = itemManager.SumIt0(10, 10); //20 döner.
            //Console.WriteLine(sumItTotal*10); //(10+10)*10 sonucu yazılır.

        }
    }
}
