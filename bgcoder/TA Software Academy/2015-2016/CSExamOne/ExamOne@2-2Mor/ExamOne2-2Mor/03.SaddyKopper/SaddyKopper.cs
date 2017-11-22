using System;
using System.Numerics;

class SaddyKopper
{
    static void Main(string[] args)
    {
        string numFromPublic = "123456789";//Console.ReadLine();
        int transformations = 0;
        BigInteger resultNum = new BigInteger();

        while (true)
        {
            string evenDigsSums = "";
            bool firstSum = true;
            while (true)
            {
                string newNum = "";
                for (int k = 0; k < numFromPublic.Length - 1; k++)
                {
                    newNum += numFromPublic[k].ToString();
                }
                numFromPublic = newNum;

                int evenDigsSum = 0;

                for (int k = 0; k < numFromPublic.Length; k += 2)
                {
                    evenDigsSum += int.Parse(numFromPublic[k].ToString());
                }

                if (numFromPublic.Length != 0)
                {
                    if (firstSum)
                    {
                        evenDigsSums += + evenDigsSum;
                        firstSum = false;
                    }
                    else
                    {
                        evenDigsSums += " " + evenDigsSum;
                    }
                }
                else
                {
                    break;
                }
            }

            BigInteger productOfSums = 1;
            string[] sums = evenDigsSums.Split(' ');
            for (int i = 0; i < sums.Length; i++)
            {
                productOfSums *= int.Parse(sums[i].ToString());
            }

            if ((transformations != 9) && ((productOfSums / 10) != 0))
            {
                numFromPublic = productOfSums.ToString();
                transformations++;
            }
            else
            {
                transformations++;
                resultNum = productOfSums;
                if (transformations == 10)
                {
                    Console.WriteLine(resultNum);
                }
                else
                {
                    Console.WriteLine(transformations);
                    Console.WriteLine(resultNum);
                }
                break;
            }
        }
    }
}

