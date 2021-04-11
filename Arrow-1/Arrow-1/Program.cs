using System;
public class Task1
{
    public static void Main()
    {
        int[] a = new int[10];
        int i;

        Console.Write("Input 10 elements in the array :\n");
        for (i = 0; i < 10; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nElements in array are: ");
        for (i = 0; i < 10; i++)
        {
            Console.Write("{0}  ", a[i]);
        }
        Console.Write("\n");
    }
}