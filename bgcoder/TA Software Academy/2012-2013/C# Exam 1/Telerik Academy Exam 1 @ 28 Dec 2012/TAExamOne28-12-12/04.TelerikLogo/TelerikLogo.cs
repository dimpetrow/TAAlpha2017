using System;

class TelerikLogo
{
    static void Main(string[] args)
    {
        int x = 27;//int.Parse(Console.ReadLine());
        int n = (x * 3) - 2;
        int z = (x / 2) + 1;
        string[][] logo = new string[n][];
        for (int i = 0; i < n; i++)
        {
            logo[i] = new string[n];
            for (int k = 0; k < n; k++)
            {
                logo[i][k] = ".";
            }
        }

        for (int i = 0, left = 0, right = n - 1, height = x / 2; i < z; i++, left++, right--, height--)
        {
            logo[height][left] = "*";
            logo[height][right] = "*";
        }
        for (int i = 0, left = x / 2, right = (n - 1) - (x / 2), height = 0; i < n; i++, height++)
        {
            logo[height][left] = "*";
            logo[height][right] = "*";

            if (i < (n / 3))
            {
                left++;
                right--;
            }
            else if (i < (n / 3) * 2)
            {
                left--;
                right++;
            }
            else if (i < (n / 3) * 3)
            {
                left++;
                right--;
            }
        }

        for (int i = 0; i < n; i++)
        {
            foreach (var item in logo[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

