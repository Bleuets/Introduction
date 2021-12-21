using System;

namespace DegerReferans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //
            //

            int number1 = 10;
            int number2 = 25;
            number1 = number2; //number 25 olur, kalır.
            number2 = 50;

            Console.WriteLine(number1);

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 1000; 

            Console.WriteLine(numbers1[0]);

            //Stack & Heap

        }
    }
}
