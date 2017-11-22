using System;

class OddNumber
{
    static void Main(string[] args)
    {
        int n = 13;//int.Parse(Console.ReadLine());
        long[] nums = { -1, 7, 7, -9223372036854775808, 7, -9223372036854775808, -3, 7, 7, -1, 7, 7, 0 };//new long[n];
        //for (int i = 0; i < n; i++)
        //{
        //    nums[i] = long.Parse(Console.ReadLine());
        //}
        long[] evenNums = new long[n];

        long count = 1;

        for (int i = 0, ind = 0; i < n; i++)
        {
            bool isRepeated = false;

            for (int check = 0; check < ind; check++)
            {
                if (nums[i] == evenNums[check])
                {
                    isRepeated = true;
                    break;
                }
            } // Check for repeated num

            if (isRepeated)
            {
                continue;
            }

            for (int k = i + 1; k < n; k++)
            {
                if (nums[i] == nums[k])
                {
                    count++;
                }
            }

            if (count % 2 == 1)
            {
                Console.WriteLine(nums[i]);
                break;
            }
            else
            {
                evenNums[ind++] = nums[i];
                count = 1;
            }
        }
    }
}

