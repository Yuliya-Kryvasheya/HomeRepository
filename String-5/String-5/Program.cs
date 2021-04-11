using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Input the string: ");
            s = Console.ReadLine();

            int s1 = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.Write("Total number of words in the string is: {0}\n", s1);
        }
    }
}