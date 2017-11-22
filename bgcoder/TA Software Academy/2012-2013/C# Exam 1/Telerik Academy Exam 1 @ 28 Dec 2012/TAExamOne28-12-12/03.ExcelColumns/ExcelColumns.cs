using System;
using System.Numerics;

class ExcelColumns
{
    static void Main(string[] args)
    {
        int n = 8;//int.Parse(Console.ReadLine());
        char[] identifier = { 'Z', 'Z', 'Z', 'Z', 'Z', 'Z', 'Z', 'Z' };
        //new char[n];
        //for (int i = 0; i < n; i++)                
        //{      
        //    identifier[i] = char.Parse(Console.ReadLine());      
        //}
        BigInteger colInd = 0;
        BigInteger multiplier = (BigInteger)Math.Pow(26, n - 1);

        for (int i = 0; i < n - 1; i++)
        {
            colInd += (identifier[i] - 64) * multiplier;
            multiplier /= 26;
        }
        colInd += identifier[n - 1] - 64;

        Console.WriteLine(colInd);
    }
}

