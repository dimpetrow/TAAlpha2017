using System;

class TribonacciTriangle
{
    static void Main(string[] args)
    {
        long tOne = 1L;//long.Parse(Console.ReadLine());
        long tTwo = -1L;//long.Parse(Console.ReadLine());
        long tThree = 1L;//long.Parse(Console.ReadLine());
        long nThTrib = new long();
        int l = 4;//int.Parse(Console.ReadLine());
        int n = 0;
        for (int i = 1; i <= l; i++)
        {
            n += i;
        }

        for (int i = 0, k = 1, row = 1; i < n; i++)
        {
            Console.Write(tOne + " ");

            nThTrib = tOne + tTwo + tThree;
            tOne = tTwo;
            tTwo = tThree;
            tThree = nThTrib;

            if (k == row)
            {
                Console.WriteLine();
                k = 1;
                row++;
            }
            else
            {
                k++;
            }
        }
    }
}

