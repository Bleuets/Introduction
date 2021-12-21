using System;

namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type Safety

            //Text
            string textString = "Text";

            //Int
            int numberInt = 10000;

            //Double
            double numberDouble = 10000.00;

            //True or False
            bool userLoggedIn = true;

            //Practice I
            if (userLoggedIn == true)
            {
                Console.WriteLine("User is logged in.");
            }
            else
            {
                Console.WriteLine("User is not logged in.");
            }

            //Practice II
            double euroY = 10.25;
            double euroT = 10.25;

            if (euroY > euroT)
            {
                Console.WriteLine("Euro is going down.");
            }
            else if (euroY < euroT)
            {
                Console.WriteLine("Euro is going up.");
            }
            else
            {
                Console.WriteLine("Euro is the same.");
            }
            //End.
        }
    }
}
