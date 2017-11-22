using System;

class ForestRoad
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int width = n;
        int height = (2 * n) - 1;
        string[][] map = new string[height][];
        for (int i = 0; i < height; i++)
        {
            map[i] = new string[width];
            for (int k = 0; k < width; k++)
            {
                map[i][k] = ".";
            }
        } // Make array map

        int right = 0;
        int top = 0;

        for (int i = 0; i < height; i++)
        {
            map[top][right] = "*";

            if (top < (height / 2))
            {
                right++;
            }
            else
            {
                right--;
            }
            top++;
        } // Make the road on map array

        for (int i = 0; i < height; i++)
        {
            foreach (var item in map[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        } // Print the map
    }
}

