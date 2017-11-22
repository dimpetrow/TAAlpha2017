using System;
using System.Numerics;

class TheSecretsOfNumbers
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();

        BigInteger specialSum = 0;
        bool even = false;
        for (int ind = n.Length - 1, position = 1; ind >= 0; ind--, position++)
        {
            int value = int.Parse(n[ind].ToString());

            if (even)
            {
                specialSum += ((value * value) * position);
                even = false;
            }
            else
            {
                specialSum += (value * (position * position));
                even = true;
            }
        } // Calculate the Special Sum of N

        Console.WriteLine(specialSum);

        string secretAlphaSec = "";
        int secretSecLength = (int)(specialSum % 10);
        int r = (int)(specialSum % 26);
        if (secretSecLength == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
        else
        {
            for (int i = 0, letterPosition = r + 1; i < secretSecLength; i++, letterPosition++)
            {
                if (letterPosition > 26)
                {
                    letterPosition = 1;
                }
                secretAlphaSec += ((char)(64 + letterPosition)).ToString();
            }
            Console.WriteLine(secretAlphaSec);
        }
    }
}

