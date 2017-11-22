using System;

class DrunkenNumbers
{
    static void Main(string[] args)
    {
        int n = 3;//int.Parse(Console.ReadLine());
        string[] drunkenNums = { "00000505", "7891", "9178" };//new string[n];
        //for (int i = 0; i < n; i++)
        //{
        //    drunkenNums[i] = string.Parse(Console.ReadLine());
        //}
        long mitkoScore = 0;
        long vladkoScore = 0;


        for (int i = 0; i < n; i++)
        {
            if (drunkenNums[i][0] == '0')
            {
                int zeros = 1;
                for (int ind = 1; drunkenNums[i][ind] == '0'; ind++)
                {
                    zeros++;
                    if (zeros == drunkenNums[i].Length)
                    {
                        break;
                    }
                }

                string withoutLeadZeros = "";
                for (int ind = zeros; ind < drunkenNums[i].Length; ind++)
                {
                    withoutLeadZeros += drunkenNums[i][ind].ToString();
                }
                drunkenNums[i] = withoutLeadZeros;
            }

            if (drunkenNums[i].Length % 2 == 0)
            {
                for (int k = 0; k < drunkenNums[i].Length; k++)
                {
                    if (k < (drunkenNums[i].Length / 2))
                    {
                        mitkoScore += long.Parse(drunkenNums[i][k].ToString());
                    }
                    else
                    {
                        vladkoScore += long.Parse(drunkenNums[i][k].ToString());
                    }
                }
            }
            else
            {
                for (int k = 0; k < drunkenNums[i].Length; k++)
                {
                    if (k < (drunkenNums[i].Length / 2))
                    {
                        mitkoScore += long.Parse(drunkenNums[i][k].ToString());
                    }
                    else if (k == (drunkenNums[i].Length / 2))
                    {
                        mitkoScore += long.Parse(drunkenNums[i][k].ToString());
                        vladkoScore += long.Parse(drunkenNums[i][k].ToString());
                    }
                    else
                    {
                        vladkoScore += long.Parse(drunkenNums[i][k].ToString());
                    }
                }
            }
        }


        if (mitkoScore > vladkoScore)
        {
            Console.WriteLine("M {0}", (mitkoScore - vladkoScore));
        }
        else if (mitkoScore < vladkoScore)
        {
            Console.WriteLine("V {0}", (vladkoScore - mitkoScore));
        }
        else
        {
            Console.WriteLine("No {0}", mitkoScore);
        }
    }
}

