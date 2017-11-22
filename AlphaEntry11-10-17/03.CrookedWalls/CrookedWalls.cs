using System;

class CrookedWalls
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] wallsStr = input.Split(' ');
        int n = wallsStr.Length;
        long[] walls = Array.ConvertAll(wallsStr, long.Parse);

        long sum = 0;


        for (int i = 1; i < n; i++)
        {
            long dist = Math.Abs(walls[i - 1] - walls[i]);

            if (dist % 2 == 0)
            {
                sum += dist;
                i += 1;
            }
        }

        Console.WriteLine(sum);
        Console.WriteLine(sum);
        Console.WriteLine(sum);
        Console.WriteLine(sum);
        Console.WriteLine(sum);
        Console.WriteLine(sum);
        Console.WriteLine(sum);
    }
}

