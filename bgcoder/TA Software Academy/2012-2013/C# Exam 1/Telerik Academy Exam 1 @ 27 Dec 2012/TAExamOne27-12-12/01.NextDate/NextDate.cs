using System;

class NextDate
{
    static void Main(string[] args)
    {
        int day = 31;//int.Parse(Console.ReadLine());
        int month = 12;//int.Parse(Console.ReadLine());
        int year = 2003;//int.Parse(Console.ReadLine());

        if (month == 2)
        {
            if ((year == 2012) || (year == 2008) || (year == 2004) || (year == 2000))
            {
                if (day == 29)
                {
                    day = 1;
                    month++;
                }
                else
                {
                    day++;
                }
            }
            else
            {
                if (day == 28)
                {
                    day = 1;
                    month++;
                }
                else
                {
                    day++;
                }
            }
        }
        else if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10))
        {
            if (day == 31)
            {
                day = 1;
                month++;
            }
            else
            {
                day++;
            }
        }
        else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
        {
            if (day == 30)
            {
                day = 1;
                month++;
            }
            else
            {
                day++;
            }
        }
        else if (month == 12)
        {
            if (day == 31)
            {
                month = 1;
                day = 1;
                year++;
            }
            else
            {
                day++;
            }
        }

        Console.WriteLine("{0}.{1}.{2}", day, month, year);
    }
}

