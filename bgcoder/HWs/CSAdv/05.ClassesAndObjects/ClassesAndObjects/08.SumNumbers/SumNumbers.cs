using System;

namespace _08.SumNumbers
{
    class SumNumbers
    {
        static int SumSequence(string seqStr)
        {
            string[] nums = seqStr.Split(' ');
            int sum = 0;

            for (int num = 0; num < nums.Length; num++)
            {
                sum += int.Parse(nums[num]);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            string numsSeq = "43 68 9 23 318";//Console.ReadLine();

            Console.WriteLine(SumSequence(numsSeq));
        }
    }
}
