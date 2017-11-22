using System;

class SearchInBits
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
        sBits = sBits.PadLeft(4, '0');


        for (int num = 0; num < nums.Length; num++)
        {
            string numBits = Convert.ToString(nums[num], 2);
            if (numBits.Length < 30)
            {
                numBits = numBits.PadLeft(30, '0');
            }
            else if (numBits.Length > 30)
            {
                string newNum = "";
                for (int bit = numBits.Length - 30; bit < numBits.Length; bit++)
                {
                    newNum += numBits[bit].ToString();
                }
                numBits = newNum;
            }

            for (int check = 26; check >= 0; check--)
            {
                string checkBits = "";
                for (int bit = check; bit < check + 4; bit++)
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

