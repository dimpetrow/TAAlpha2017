using System;

class ThreeNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int biggest = new int();
        int smallest = new int();
        double arithMean = (double)(a + b + c) / 3;

        if ((a >= b) && (a >= c))
        {
            biggest = a;
        }
        else if ((b >= a) && (b >= c))
        {
            biggest = b;
        }
        else if ((c >= b) && (c >= a))
        {
            biggest = c;
        }

        if ((a <= b) && (a <= c))
        {
            smallest = a;
        }
        else if ((b <= a) && (b <= c))
        {
            smallest = b;
        }
        else if ((c <= b) && (c <= a))
        {
            smallest = c;
        }

        Console.WriteLine(biggest);
        Console.WriteLine(smallest);
        Console.WriteLine("{0:f2}",arithMean);
    }
}


