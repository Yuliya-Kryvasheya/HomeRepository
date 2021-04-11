using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i = 0;
            Console.Write("Input the string: ");
            s = Console.ReadLine();
            i = s.Length - 1;
            Console.Write("The characters of the string in reverse are: \n");
            _ = s.Split(' ');

            foreach (var c1 in s)
            
            while (i >= 0)
            {
                Console.Write("{0} ", s[i]);
                i--;
            }
            Console.Write("\n\n");
        }
        
    }
}