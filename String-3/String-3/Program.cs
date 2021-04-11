using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Input the string: ");
            s = Console.ReadLine();

            Console.Write("The characters of the string are:  ");
            _ = s.Split(' ');

            foreach (var c1 in s)
            {
                Console.Write($" {c1} ");
            }
            
        }
    }
}