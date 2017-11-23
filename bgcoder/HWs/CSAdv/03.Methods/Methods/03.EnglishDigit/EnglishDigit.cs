using System;

class EnglishDigit
{
    static string GetLastDigitAsWord(int x)
    {
        string lastDig = "";
        switch (x % 10)
        {
            case 0:
                lastDig = "zero";
                break;
            case 1:
                lastDig = "one";
                break;
            case 2:
                lastDig = "two";
                break;
            case 3:
                lastDig = "three";
                break;
            case 4:
                lastDig = "four";
                break;
            case 5:
                lastDig = "five";
                break;
            case 6:
                lastDig = "six";
                break;
            case 7:
                lastDig = "seven";
                break;
            case 8:
                lastDig = "eight";
                break;
            case 9:
                lastDig = "nine";
                break;
            default:
                break;
        }
        return lastDig;
    }

    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLastDigitAsWord(num));
    }
}

