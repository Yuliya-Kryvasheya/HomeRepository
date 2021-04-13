using System;

public class Task3
{
    public static void Main()
    {
        int[] a = new int[50];
        int n;
        Console.Write("Input the number of elements to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input {0} elements in the array :\n", n);

        for (int i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        float Sum = 0;
        for (int i = 0; i < n; i++)
        {
            Sum += a[i];
        }

        Console.WriteLine("Sum of all elements stored in the array is: " + Sum);
    }
}