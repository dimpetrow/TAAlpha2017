using System;

class Eggcelent
{
    static void Main(string[] args)
    {
        int n = 6;//int.Parse(Console.ReadLine());

        int height = n * 2;
        int width = (n * 3) - 1;
        int areaWidth = (n * 3) + 1;

        char[][] egg = new char[height][];
        for (int row = 0; row < height; row++)
        {
            egg[row] = new char[areaWidth];
            for (int col = 0; col < areaWidth; col++)
            {
                egg[row][col] = '.';
            }
        }

        for (int row = 0, start = n + 1, end = areaWidth - (n + 1), countEnlargement = 1; row < height; row++)
        {
            bool stop = false;

            for (int col = start; col < end;)
            {
                egg[row][col] = '*';

                if (stop)
                {
                    break;
                }

                if ((row == 0) || (row == height - 1))
                {
                    col++;
                }
                else
                {
                    col = end - 1;
                    stop = true;
                }
            }

            if (row == n - 1)
            {
                for (int col = start + 1; col < end - 1; col += 2)
                {
                    egg[row][col] = '@';
                }
            }
            else if (row == n)
            {
                for (int col = start + 2; col < end - 2; col += 2)
                {
                    egg[row][col] = '@';
                }
            }

            if ((row < height / 2) && (start > 1))
            {
                start -= 2;
                end += 2;
                countEnlargement++;
            }
            else if ((row >= height - countEnlargement) && (start < n + 1))
            {
                start += 2;
                end -= 2;
            }
        }

        for (int i = 0; i < height; i++)
        {
            foreach (var item in egg[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

