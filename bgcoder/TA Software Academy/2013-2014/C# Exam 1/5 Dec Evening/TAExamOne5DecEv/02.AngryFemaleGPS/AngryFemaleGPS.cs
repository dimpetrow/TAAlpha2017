using System;

class AngryFemaleGPS
{
    static void Main(string[] args)
    {
        string num = "112";//Console.ReadLine();
        int n = num.Length;
        int oddSum = 0;
        int evenSum = 0;

        for (int p = 0; p < n; p++)
        {
            int numAtP = new int();
            bool isNumAtP = int.TryParse(num[p].ToString(), out numAtP);
            if (isNumAtP)
            {
                if (numAtP % 2 == 0)
                {
                    evenSum += numAtP;
                }
                else
                {
                    oddSum += numAtP;
                }
            }
        }

        if (evenSum > oddSum)
        {
            Console.WriteLine("right " + evenSum);
        }
        else if (evenSum < oddSum)
        {
            Console.WriteLine("left " + oddSum);
        }
        else
        {
            Console.WriteLine("straight " + evenSum);
        }
    }
}
