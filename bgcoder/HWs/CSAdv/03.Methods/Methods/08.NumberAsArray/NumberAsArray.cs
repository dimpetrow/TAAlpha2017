using System;

class NumberAsArray
{
    static int[] SumOfArrays(string sizesOfArrays, string fArrStr, string sArrStr)
    {
        int fSize = int.Parse(sizesOfArrays.Split(' ')[0]);
        int sSize = int.Parse(sizesOfArrays.Split(' ')[1]);

        string[] fArr = fArrStr.Split(' ');
        string[] sArr = sArrStr.Split(' ');

        int[] sumOfNums = new int[Math.Max(fSize, sSize)];

        for (int i = 0; i < sumOfNums.Length; i++)
        {
            int sumOfDig = 0;
            if (i < fArr.Length)
            {
                sumOfDig += int.Parse(fArr[i]);
            }
            if (i < sArr.Length)
            {
                sumOfDig += int.Parse(sArr[i]);
            }

            if (sumOfDig >= 10)
            {
                sumOfNums[i] += sumOfDig % 10;

                if (i != sumOfNums.Length - 1)
                {
                    sumOfNums[i + 1]++;
                }
            }
            else
            {
                sumOfNums[i] += sumOfDig;
            }
        }

        return sumOfNums;
    }

    static void Main(string[] args)
    {
        string sizes = Console.ReadLine();
        string firstArr = Console.ReadLine();
        string secondArr = Console.ReadLine();

        int[] sumOfArrays = SumOfArrays(sizes, firstArr, secondArr);

        Console.WriteLine(string.Join(" ", sumOfArrays));
    }
}

