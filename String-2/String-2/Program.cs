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
            int s1 = s.Length;
            Console.Write("Length of the string is: {0}\n", s1);
        }
    }
}