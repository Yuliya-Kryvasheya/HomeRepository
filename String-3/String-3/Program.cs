using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string: ");
            var s = Console.ReadLine();

            Console.Write("The characters of the string are:  ");
            
            foreach (var c1 in s)
            {
                Console.Write($" {c1} ");
            }
            
        }
    }
}