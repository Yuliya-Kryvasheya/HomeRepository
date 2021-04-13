using System;

public class Task5
{
    public static void Main()
    {
        int[] a = new int[50];
        int[] a1 = new int[50];
        int[] a2 = new int[50];

        int n, i, j, mm = 1, ctr = 0;
        Console.Write("Input the number of elements to store in the array :");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input 10 elements in the array :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            a1[i] = a[i];
            a2[i] = 0;
        }
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (a[i] == a1[j])
                {
                    a2[j] = mm;
                    mm++;
                }
            }
            mm = 1;

            for (i = 0; i < n; i++)
            {
                if (a2[i] == 2) { ctr++; }
            }
            Console.Write("The number of duplicate elements is: {0} \n", ctr);

            Console.Write("\n\n");
        }
    }
}