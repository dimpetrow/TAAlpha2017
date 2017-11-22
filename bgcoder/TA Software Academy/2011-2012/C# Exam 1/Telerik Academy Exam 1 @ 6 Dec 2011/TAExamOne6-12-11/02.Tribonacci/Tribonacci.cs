using System;
using System.Numerics;

class Tribonacci
{
    static void Main(string[] args)
    {
        BigInteger tOne = 1;// BigInteger.Parse(Console.ReadLine());
        BigInteger tTwo = 1;// BigInteger.Parse(Console.ReadLine());
        BigInteger tThree = 1;// BigInteger.Parse(Console.ReadLine());
        BigInteger nThTribNum = new BigInteger();
        int n = 5;// int.Parse(Console.ReadLine());

        for (int i = 3; i < n; i++)
        {
            nThTribNum = tThree + tTwo + tOne;
            tOne = tTwo;
            tTwo = tThree;
            tThree = nThTribNum;
        }

        Console.WriteLine(nThTribNum);
    }
}

