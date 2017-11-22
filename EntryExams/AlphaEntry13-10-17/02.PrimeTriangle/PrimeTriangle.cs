using System;

class PrimeTriangle
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string onesNZeros = "111";

        Console.WriteLine("1");
        Console.WriteLine("11");
        Console.WriteLine("111");

        for (int num = 4; num <= n; num++)
        {
            bool isPrime = true;

            for (int divisor = 2; divisor < num; divisor++)
            {
                if ((num % divisor) == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                onesNZeros += "1";
                Console.WriteLine(onesNZeros);
            }
            else
            {
                onesNZeros += "0";
            }
        }
        
    }
}

