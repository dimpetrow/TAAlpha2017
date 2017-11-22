using System;

class DancingBits
{
    static void Main(string[] args)
    {
        int k = 3;//int.Parse(Console.ReadLine());
        int n = 4;//int.Parse(Console.ReadLine());
        int[] nums = { 5, 6, 14, 143 };//new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    nums[i] = int.Parse(Console.ReadLine());
        //}

        string concatBits = "";
        for (int i = 0; i < n; i++)
        {
            concatBits += Convert.ToString(nums[i], 2);
        }

        int countDanceBits = 0;

        for (int i = 0, count = 0; i < concatBits.Length - 1; i++)
        {
            if (concatBits[i] == '0')
            {
                count++;
            }
            else
            {
                count = 0;
            }

            if ((count == k) && (concatBits[i + 1] != '0'))
            {
                countDanceBits++;
                count = 0;
            }
        }

        for (int i = 0, count = 1; i < concatBits.Length - 1; i++)
        {
            if (concatBits[i] == '1')
            {
                count++;
            }
            else
            {
                count = 0;
            }

            if ((count == k) && (concatBits[i + 1] != '1'))
            {
                countDanceBits++;
                count = 0;
            }
        }

        Console.WriteLine(countDanceBits);
    }
}

