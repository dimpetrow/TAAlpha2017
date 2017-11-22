using System;

class TheHorror
{
    static void Main(string[] args)
    {
        string digits = Console.ReadLine();
        int digitsAmount = 0;
        long sum = 0;
        for (int i = 0; i < digits.Length; i += 2)
        {
            int num = new int();
            bool isNum = int.TryParse(digits[i].ToString(), out num);
            if (isNum)
            {
                sum += num;
                digitsAmount++;
            }
        }
        Console.WriteLine(digitsAmount + " " + sum);
    }
}

