using System;

class ReverseNumber
{
    static string ReverseNum(string number)
    {
        string reversedNumber = "";

        for (int dig = number.Length - 1; dig >= 0; dig--)
        {
            reversedNumber += number[dig];
        }

        return reversedNumber;
    }

    static void Main(string[] args)
    {
        string num = Console.ReadLine();

        Console.WriteLine(ReverseNum(num));
    }
}
