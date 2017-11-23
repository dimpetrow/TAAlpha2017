using System;

class LargerThanNeighbours
{
    static int GetCountOfNumsLargerThanNeigh(int[] arr)
    {
        int count = 0;

        for (int ind = 1; ind < arr.Length - 1; ind++)
        {
            if ((arr[ind] > arr[ind - 1]) && (arr[ind] > arr[ind - 1]))
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
        Console.WriteLine(GetCountOfNumsLargerThanNeigh(nums));
    }
}

