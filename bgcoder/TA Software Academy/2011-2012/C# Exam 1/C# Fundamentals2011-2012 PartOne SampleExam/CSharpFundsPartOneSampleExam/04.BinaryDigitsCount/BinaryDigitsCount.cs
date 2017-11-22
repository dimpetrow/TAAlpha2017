using System;

class BinaryDigitsCount
{
    static void Main(string[] args)
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] nums = new long[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }
        int countBins = 0;
        int[] countBinsOfNums = new int[n];

        for (long i = 0, num; i < n; i++)
        {
            num = nums[i];

            while (num > 0)
            {
                if ((num % 2 == 0) && (b == 0))
                {
                    countBins++;
                }
                else if ((num % 2 == 1) && (b == 1))
                {
                    countBins++;
                }

                num /= 2;
            }

            countBinsOfNums[i] = countBins;
            countBins = 0;
        }

        foreach (var item in countBinsOfNums)
        {
            Console.WriteLine(item);
        }
    }
}
