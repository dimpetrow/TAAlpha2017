using System;

class MathExpression
{
    static void Main(string[] args)
    {
        decimal n = 0.123456m; //decimal.Parse(Console.ReadLine());
        decimal m = 1.234567m; //decimal.Parse(Console.ReadLine());
        decimal p = 2.345678m; //decimal.Parse(Console.ReadLine());

        decimal expression = (((n * n) + (1m / (m * p)) + 1337m) / (n - (128.523123123m * p))) + (decimal)Math.Sin((int)(m % 180m));

        Console.WriteLine("{0:f6}",expression);
    }
}

