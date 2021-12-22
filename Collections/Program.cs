using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //

            //string[] names = new string[] 
            //{
            //"Name 1",
            //"Name 2",
            //"Name 3",
            //"Name 4"
            //};

            //CTRL K, CTRL C - Comment
            //CTRL K, CTRL U - Uncomment

            //Diziler sınırları içerisinde belirlenir.
            //names[4] ile genişletilemez, eleman atanamaz.
            //names = new string[5] ile büyütülürse, yeni referans atanır, eski üyeler kaybolur.


            //List için System.Collections.Generic;
            List<string> names2 = new List<string> 
            {
                "Name 1",
                "Name 2",
                "Name 3",
                "Name 4",
            };

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("An Added Name");
            Console.WriteLine(names2[4]);

            //Added Name'de okunur/print edilir.

            

        }
    }
}
