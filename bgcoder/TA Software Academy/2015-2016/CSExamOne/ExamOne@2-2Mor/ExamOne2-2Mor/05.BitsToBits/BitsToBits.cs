using System;

class BitsToBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long num = new long();
        string bits = "";
        for (int i = 0; i < n; i++)
        {
            num = long.Parse(Console.ReadLine());
            string numInBin = Convert.ToString(num, 2);

            if (numInBin.Length < 30)
            {
                numInBin = numInBin.PadLeft(30, '0');
            }
            else if (numInBin.Length > 30)
            {
                string newNum = "";
                for (int k = numInBin.Length - 30; k < numInBin.Length; k++)
                {
                    newNum += numInBin[k];
                }
                numInBin = newNum;
            }

            bits += numInBin;
        }

        int longestZeroSeq = new int();
        int longestOnesSeq = new int();

        bool isZero = (bits[0] == '0');
        for (int i = 0, currentZeroCount = 0, currentOnesCount = 0; i < bits.Length; i++)
        {
            isZero = (bits[i] == '0');
            if (isZero)
            {
                if (currentOnesCount != 0)
                {
                    if (currentOnesCount > longestOnesSeq)
                    {
                        longestOnesSeq = currentOnesCount;
                    }

                    currentOnesCount = 0;
                }

                currentZeroCount++;
            }
            else
            {
                if (currentZeroCount != 0)
                {
                    if (currentZeroCount > longestZeroSeq)
                    {
                        longestZeroSeq = currentZeroCount;
                    }

                    currentZeroCount = 0;
                }

                currentOnesCount++;
            }

            if (i == bits.Length - 1)
            {
                longestOnesSeq = Math.Max(longestOnesSeq,currentOnesCount);
                longestZeroSeq = Math.Max(longestZeroSeq, currentZeroCount);
            }
        }

        Console.WriteLine(longestZeroSeq);
        Console.WriteLine(longestOnesSeq);
    }
}

