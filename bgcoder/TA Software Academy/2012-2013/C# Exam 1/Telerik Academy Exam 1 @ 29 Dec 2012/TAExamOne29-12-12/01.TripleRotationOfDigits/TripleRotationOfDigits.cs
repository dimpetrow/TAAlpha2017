using System;

class TripleRotationOfDigits
{
    static void Main(string[] args)
    {
        string k = "999008";//Console.ReadLine();
        for (int i = 0; i < 3; i++)
        {
            string last = k[k.Length - 1].ToString();
            string newK = "";
            for (int j = 0; j < k.Length - 1; j++)
            {
                newK += k[j];
            }
            k = last + newK;
        }

        while (true)
        {
            int i = 0;
            string newK = "";

            if (k[i] != '0')
            {
                break;
            }
            else
            {
                for (int j = i + 1; j < k.Length; j++)
                {
                    newK += k[j];
                }
            }

            k = newK;
        }

        Console.WriteLine(k);
    }
}

