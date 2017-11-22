using System;
using System.Numerics;

class ThreeSixNine
{
    static void Main(string[] args)
    {
        BigInteger a = 942422;//BigInteger.Parse(Console.ReadLine());
        BigInteger b = 9;//BigInteger.Parse(Console.ReadLine());
        BigInteger c = 523524234;//BigInteger.Parse(Console.ReadLine());

        BigInteger r = new BigInteger();

        if (b == 3)
        {
            r = a + c;
        }
        else if (b == 6)
        {
            r = a * c;
        }
        else if (b == 9)
        {
            r = a % c;
        }

        if (r % 3 == 0)
        {
            Console.WriteLine(r / 3);
        }
        else
        {
            Console.WriteLine(r % 3);
        }

        Console.WriteLine(r);
    }
}

