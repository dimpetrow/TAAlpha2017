using System;

class WeAllLoveBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            string pNormalStr = Convert.ToString(nums[i], 2); // Convert to String
            string pInvBitsStr = "";
            char[] pInvBitsArr = pNormalStr.ToCharArray();
            string pRevBitsStr = "";

            for (int k = pNormalStr.Length - 1, j = 0; k >= 0; k--, j++)
            {
                pRevBitsStr += pNormalStr[k];

                if (pInvBitsArr[j] == '0')
                {
                    pInvBitsArr[j] = '1';
                    pInvBitsStr += pInvBitsArr[j];
                }
                else
                {
                    pInvBitsArr[j] = '0';
                    pInvBitsStr += pInvBitsArr[j];
                }
            } // Reverse and invert bits

            int pNormal = 0;
            int pInvBits = 0;
            int pRevBits = 0;

            for (int k = pNormalStr.Length - 1, power = 0; k >= 0; k--, power++)
            {
                if (pNormalStr[k] == '1')
                {
                    pNormal += (int)Math.Pow(2, power);
                }

                if (pInvBitsStr[k] == '1')
                {
                    pInvBits += (int)Math.Pow(2, power);
                }

                if (pRevBitsStr[k] == '1')
                {
                    pRevBits += (int)Math.Pow(2, power);
                }
            } // Back to Integer

            int pNew = ((pNormal ^ pInvBits) & pRevBits);

            Console.WriteLine(pNew);
        } // Mitko's algorithm
    }
}

