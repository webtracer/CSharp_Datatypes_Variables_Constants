using System;

namespace Constants
{
    class Program
    {
        //variables which are outside any methods, but inside the class
        //constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string myBirthday = "04/24/1971";

        static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is {myBirthday}");

        }
    }
}
