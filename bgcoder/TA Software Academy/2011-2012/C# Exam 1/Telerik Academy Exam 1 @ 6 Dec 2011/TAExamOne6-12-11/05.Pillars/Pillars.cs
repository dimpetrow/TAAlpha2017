using System;

class Pillars
{
    static void Main(string[] args)
    {
        int[] rows = new int[8];
        for (int i = 0; i < 8; i++)
        {
            rows[i] = int.Parse(Console.ReadLine());
        }

        string[][] grid = new string[8][];
        for (int i = 0; i < 8; i++)
        {
            grid[i] = new string[8];

            for (int k = 0; k < 8; k++)
            {
                grid[i][k] = "0";
            } //

            string line = Convert.ToString(rows[i], 2);

            if (line == "0")
            {
                continue;
            }

            string zeros = "";
            for (int k = 0, end = 8 - line.Length; k < end; k++)
            {
                zeros += "0";
            }
            line = zeros + line;

            for (int k = 0; k < 8; k++)
            {
                if (line[k] == '1')
                {
                    grid[i][8 - k - 1] = "1";
                }
            }
        } // Fill the grid with input data

        for (int i = 0; i < 8; i++)
        {
            foreach (var item in grid[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        for (int i = 1, leftSide = 0, rightSide = 0, indexer = 0; i < 7; i++)
        {
            while (indexer < i)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (grid[k][indexer] == "1")
                    {
                        leftSide++;
                    }
                }

                indexer++;
            }

            indexer++;

            while (indexer < 8)
            {
                for (int k = 0; k < 8; k++)
                {
                    if (grid[k][indexer] == "1")
                    {
                        rightSide++;
                    }
                }

                indexer++;
            }

            if (rightSide == leftSide)
            {
                Console.WriteLine(i);
                Console.WriteLine(rightSide);
                break;
            }


            if (i == 6)
            {
                Console.WriteLine("No");
                break;
            }

            indexer = 0;
            rightSide = 0;
            leftSide = 0;
        }
        // Count bits on left and right sides and check if they are equal
    }
}

