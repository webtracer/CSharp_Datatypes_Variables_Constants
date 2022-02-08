using System;

namespace Datatypes_And_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            char myChar = 'a';
            string myString = "This is my string";
            int myInt = 14;
            float myFloat = 3.1417f;
            double myDouble = 20.98756343092384985434;
            long myLong = 15987654;
            bool myBool = false;

            string string1 = "I control Text";
            string string2 = "32";

            Console.WriteLine($"The character I chose was {myChar}");
            Console.WriteLine($"The string I chose reads '{myString}");
            Console.WriteLine($"Tne integer I selected is {myInt.ToString()}");
            Console.WriteLine($"The Floating Point number I put is {myFloat}");
            Console.WriteLine($"I chose {myDouble} as a Double exanple");
            Console.WriteLine($"The Long example I picked is {myLong}");
            Console.WriteLine($"The Boolean value I picked is {myBool.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"Instructions require me to use this string: '{string1}'");
            Console.WriteLine($"The requested integer is {Int32.Parse(string2)}");
        }
    }
}
