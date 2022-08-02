using System;

namespace IntegerTypeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            Console.WriteLine("Number:" + typeCheckInt(str) );
        }

        static bool typeCheckInt(String input)
        {
            int number = 0;
            return int.TryParse(input, out number);
        }
    }
}