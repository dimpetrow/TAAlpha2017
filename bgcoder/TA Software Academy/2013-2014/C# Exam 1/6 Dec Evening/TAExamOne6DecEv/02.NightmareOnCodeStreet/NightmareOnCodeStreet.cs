using System;

class NightmareOnCodeStreet
{
    static void Main(string[] args)
    {
        string digits = "123";//Console.ReadLine();
        int count = 0;
        int sum = 0;
        bool isDigit = false;

        for (int i = 1, num = new int(); i < digits.Length; i += 2)
        {
            string getD = digits[i].ToString();
            isDigit = int.TryParse(getD, out num);

            if (isDigit)
            {
                sum += num;
                count++;
            }
        }

        Console.WriteLine(count + " " + sum);
    }
}

