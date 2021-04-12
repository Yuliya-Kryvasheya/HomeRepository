using System;
public class Exercise4
{
    public static void Main()
    {
        int[] a = new int[100];
        int[] b = new int[100];
        int n;


        Console.Write("Input the number of elements to be stored in the array: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input {0} elements in the array :\n", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for (int i = 0; i < n; i++)
        {
            b[i] = a[i];
        }

        Console.Write("\nThe elements stored in the first array are: \n");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}  ", a[i]);
        }

        Console.Write("\n\nThe elements copied into the second array are: \n");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}  ", b[i]);
        }
        Console.Write("\n\n");
    }
}