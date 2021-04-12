using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = InputArrayElements();
            WriteArrayElements(a);
        }

        public static int[] InputArrayElements()
        {
            int[] a = new int[10];

            Console.WriteLine("Input 10 elements in the array:");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                var inputString = Console.ReadLine().Trim();

                if (!int.TryParse(inputString, out a[i]))
                {
                    Console.WriteLine("Please enter a correct value!");
                    i--;
                    continue;
                }
            }
            return a;
        }

        public static void WriteArrayElements(int[] arr)
        {
            Console.Write("\nElements in array are:");

            foreach (int elemet in arr)
            {
                Console.Write(" {0}", elemet);
            }
        }
    }
}