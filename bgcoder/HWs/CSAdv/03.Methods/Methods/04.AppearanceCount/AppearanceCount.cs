using System;

class AppearanceCount
{
    static int GetAppearanceCountOfNumInArr(int num, int[] arr)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (num == arr[i])
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(input.Split(' ')[i]);
        }
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(GetAppearanceCountOfNumInArr(x, nums));
    }
}

