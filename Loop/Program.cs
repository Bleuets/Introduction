using System;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice III
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(i);
            }

            //Use arrays, don't do this.
            //
            //
            //string lesson1 = "Lesson 1";
            //string lesson2 = "Lesson 2";
            //string lesson3 = "Lesson 3"
            //
            //

            string[] lessons = new string[] { 
            "Lesson 1",
            "Lesson 2",
            "Lesson 3",
            "Lesson 4",
            "Lesson 5"
            };

            for (int i = 0; i < lessons.Length; i++)
            {
                Console.WriteLine(lessons[i]);
            }

            Console.WriteLine("Status: 'for' loop ended, 'foreach' loop started.");

            //Practice: foreach for arrays.
            
            foreach (string lesson in lessons)
            {
                Console.WriteLine(lesson);
            }

            Console.WriteLine("End of the page.");
            //End.
        }
    }
}
