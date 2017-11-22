using System;

class Printing
{
    static void Main(string[] args)
    {
        int n = 686;//int.Parse(Console.ReadLine());
        int s = 7;//int.Parse(Console.ReadLine());
        double p = 4.98d;//double.Parse(Console.ReadLine());
        double sum = 0d;

        int totalAmOfPaper = n * s;

        for (int i = totalAmOfPaper; i >= 0; i -= 500)
        {
            if (i >= 500)
            {
                sum += p;
            }
            else
            {
                sum += ((double)i / 500) * p;
            }
        }

        Console.WriteLine("{0:f2}",sum);
    }
}

