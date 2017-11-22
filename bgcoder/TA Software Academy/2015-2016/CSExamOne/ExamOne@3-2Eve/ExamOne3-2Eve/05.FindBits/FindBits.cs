using System;

class FindBits
{
    static void Main(string[] args)
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        int occurancies = 0;
        string sBits = Convert.ToString(s, 2);
        sBits = sBits.PadLeft(5, '0');


        for (int num = 0; num < nums.Length; num++)
        {
            string numBits = Convert.ToString(nums[num], 2);
            if (numBits.Length < 29)
            {
                numBits = numBits.PadLeft(29, '0');
            }
            else if (numBits.Length > 29)
            {
                string newNum = "";
                for (int bit = numBits.Length - 29; bit < numBits.Length; bit++)
                {
                    newNum += numBits[bit].ToString();
                }
                numBits = newNum;
            }

            for (int check = 24; check >= 0; check--)
            {
                string checkBits = "";
                for (int bit = check; bit < check + 5; bit++)
                {
                    checkBits += numBits[bit].ToString();
                }

                if (sBits == checkBits)
                {
                    occurancies++;
                }
            }
        }

        Console.WriteLine(occurancies);
    }
}

