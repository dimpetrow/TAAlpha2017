using System;

class SevenlandNumbers
{
    static void Main(string[] args)
    {
        int k = 666;// int.Parse(Console.ReadLine());
        string kStr = "";

        if ((k % 10 == 6) && ((k / 10) % 10) != 6)
        {
            if (((k / 10).ToString().Length == 1) && ((k / 10).ToString() == "0"))
            {
                kStr = "10";
            }
            else if (((k / 10).ToString().Length == 1) && ((k / 10).ToString() != "0"))
            {
                kStr = ((k / 10) + 1).ToString() + "0";
            }
            else if ((k / 10).ToString().Length == 2)
            {
                kStr = ((k / 10) + 1).ToString() + "0";
            }
        }
        else if ((k % 100 == 66) && ((k / 100) % 10) != 6)
        {
            if (((k / 100).ToString().Length == 1) && ((k / 100).ToString() == "0"))
            {
                kStr = "100";
            }
            else if (((k / 100).ToString().Length == 1) && ((k / 100).ToString() != "0"))
            {
                kStr = ((k / 100) + 1).ToString() + "00";
            }
        }
        else if ((k % 1000) == 666)
        {
            kStr = "1000";
        }
        else
        {
            kStr = (k + 1).ToString();
        }

        Console.WriteLine(kStr);
    }
}

