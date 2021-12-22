using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class ItemManager
    {
        public void Add(Item item)
        {
            Console.WriteLine(item.ItemName + " eklendi.");
        }

        public void Update(Item item) 
        {
            Console.WriteLine(item.ItemName + " güncellendi.");
        }



        //public int SumIt0(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //public void SumIt1(int num1, int num2)
        //{
        //    Console.WriteLine(num1 + num2);
        //}

    }
}
