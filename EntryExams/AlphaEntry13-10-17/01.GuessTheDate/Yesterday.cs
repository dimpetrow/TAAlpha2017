using System;

class Yesterday
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        DateTime inputDate = new DateTime(year, month, day);
        DateTime previousDate = inputDate.AddDays(-1);

        Console.WriteLine(previousDate.ToString("d-MMM-yyyy"));
    }
}
