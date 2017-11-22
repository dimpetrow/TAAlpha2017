using System;

class PeaceOfCake
{
    static void Main(string[] args)
    {
        decimal a = 3;//decimal.Parse(Console.ReadLine());
        decimal b = 5;//decimal.Parse(Console.ReadLine());
        decimal c = 1;//decimal.Parse(Console.ReadLine());
        decimal d = 2;//decimal.Parse(Console.ReadLine());

        decimal result = (a / b) + (c / d);

        if (result < 1)
        {
            Console.WriteLine("{0:f22}", Math.Round(result, 22));
        }
        else
        {
            Console.WriteLine((int)result);
        }

        Console.WriteLine("{0}/{1}", (a * d) + (c * b),(b*d));
    }
}
