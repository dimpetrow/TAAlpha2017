using System;

class GetLargestNumber
{
    static int GetMax(int x, int y)
    {
        int max = x;
        if (y > x)
        {
            max = y;
        }
        return max;
    }

    static void Main(string[] args)
    {
        string nums = Console.ReadLine();
        int a = int.Parse(nums.Split(' ')[0]);
        int b = int.Parse(nums.Split(' ')[1]);
        int c = int.Parse(nums.Split(' ')[2]);

        Console.WriteLine(GetMax(a, GetMax(b, c)));
    }
}

