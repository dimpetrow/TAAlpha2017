using System;

class DiamondTrolls
{
    static void Main(string[] args)
    {
        int n = 27;//int.Parse(Console.ReadLine());

        int width = (n * 2) + 1;
        int height = (((n - 3) / 2) * 3) + 6;

        char[][] diamond = new char[height][];
        for (int row = 0; row < height; row++)
        {
            diamond[row] = new char[width];
            for (int col = 0; col < width; col++)
            {
                diamond[row][col] = '.';
            }
        }

        bool fullRow = true;
        bool oposite = false;
        for (int row = 0, start = (width - n) / 2, end = ((width - n) / 2) + (n - 1); row < height; row++)
        {
            for (int col = start; col <= end; col++)
            {
                if (fullRow)
                {
                    diamond[row][col] = '*';
                }
                else if ((col == start) || (col == (width / 2)) || (col == end))
                {
                    diamond[row][col] = '*';
                }

                if ((col == end) && (fullRow))
                {
                    fullRow = false;
                }
            }

            if (start == 0)
            {
                oposite = true;
            }

            if (oposite)
            {
                start++;
                end--;
            }
            else
            {
                start--;
                end++;
            }

            if (start == 0)
            {
                fullRow = true;
            }
        }


        for (int i = 0; i < height; i++)
        {
            foreach (var item in diamond[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
