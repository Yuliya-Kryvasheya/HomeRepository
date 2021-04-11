using System;

public class Task2
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

        Console.Write("\nThe values store into the array are: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}  ", a[i]);
        }
        Console.Write("\n");

        Console.Write("\nThe values store into the array in reverse are: ");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write("{0} ", a[i]);
        }

        Console.Write("\n\n");
    }
}