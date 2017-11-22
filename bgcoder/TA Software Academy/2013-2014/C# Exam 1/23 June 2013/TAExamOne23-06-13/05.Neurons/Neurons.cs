using System;
using System.Collections.Generic;

class Neurons
{
    static void Main(string[] args)
    {
        //int input = new int();
        List<int> nums = new List<int>() { 480, 272, 224, 16252928, 50593792, 33685504, 67239936, 67174400, 33587200, 16809984, 16973824, 8650752, 7864320, 0, -1 };
        //while (true)
        //{
        //    input = int.Parse(Console.ReadLine());
        //    if (input == -1)
        //    {
        //        break;
        //    }
        //    nums.Add(input);
        //}

        int n = nums.Count - 1;
        char[][] picture = new char[n][];
        for (int i = 0; i < n; i++)
        {
            string row = Convert.ToString(nums[i], 2);
            row = row.PadLeft(32, '0');

            picture[i] = new char[32];
            for (int k = 0; k < 32; k++)
            {
                picture[i][k] = row[k];
            }
        } // Get picture from input



        for (int i = 0; i < n; i++)
        {
            foreach (var item in picture[i])
            {
                if (item == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
        } // Printer
    }
}

