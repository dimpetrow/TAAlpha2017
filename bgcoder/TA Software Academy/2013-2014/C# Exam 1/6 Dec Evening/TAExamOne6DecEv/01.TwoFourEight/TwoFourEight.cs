using System;
using System.Numerics;

class TwoFourEight
{
    static void Main(string[] args)
    {
        BigInteger a = 10;//BigInteger.Parse(Console.ReadLine());
        BigInteger b = 2;//BigInteger.Parse(Console.ReadLine());
        BigInteger c = 6;//BigInteger.Parse(Console.ReadLine());
        BigInteger r = new BigInteger();


        if (b == 2)
        {
            r = (a % c);
        }
        else if (b == 4)
        {
            r = (a + c);
        }
        else if (b == 8)
        {
            r = (a * c);
        }
        
        if (r % 4 == 0)
        {
            Console.WriteLine(r / 4);
        }
        else
        {
            Console.WriteLine(r % 4);
        }

        Console.WriteLine(r);
    }
}
