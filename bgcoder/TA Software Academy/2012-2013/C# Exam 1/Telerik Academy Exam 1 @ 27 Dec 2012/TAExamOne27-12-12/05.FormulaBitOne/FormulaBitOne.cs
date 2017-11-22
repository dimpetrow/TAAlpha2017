using System;

class FormulaBitOne
{
    static void Main(string[] args)
    {
        int[] rows = { 0, 0, 0, 0, 0, 0, 0, 0, };//new int[8];
        //for (int i = 0; i < 8; i++)
        //{
        //    rows[i] = int.Parse(Console.ReadLine());
        //}

        string[][] grid = new string[8][];
        string numsBin = "";
        for (int i = 0; i < 8; i++)
        {
            numsBin = Convert.ToString(rows[i], 2);
            numsBin = numsBin.PadLeft(8, '0');
            grid[i] = new string[8];
            for (int k = 0; k < 8; k++)
            {
                grid[i][k] += numsBin[k];
            }

        }

        for (int i = 0; i < 8; i++)
        {
            foreach (var item in grid[i])
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        int trackLength = 1;
        int turnsCount = 0;

        int x = 7;
        int y = 0;

        for (int i = 0, n = 1, w = 2, s = 3, dir = s, nextDir = n; i < 8 * 8; i++)
        {
            if (dir == s)
            {
                if ((y < 7) && (grid[y + 1][x] == "0"))
                {
                    trackLength++;

                    if (((y + 1) == 7) && (x == 0))
                    {
                        Console.WriteLine("{0} {1}", trackLength, turnsCount);
                        break;
                    }

                    y++;
                }
                else if (((y == 0) && (x == 7)) && (grid[y + 1][x] == "1"))
                {
                    Console.WriteLine("No {0}", trackLength);
                    break;
                }
                else if ((x == 0) && (grid[y + 1][x] == "1"))
                {
                    Console.WriteLine("No {0}", trackLength);
                    break;
                }
                else if ((y == 7) && (grid[y][x - 1] == "1"))
                {
                    Console.WriteLine("No {0}", trackLength);
                    break;
                }
                else
                {
                    turnsCount++;
                    dir = w;
                }
            }
            else if (dir == w)
            {
                if ((x > 0) && (grid[y][x - 1] == "0"))
                {
                    trackLength++;

                    if ((y == 7) && ((x - 1) == 0))
                    {
                        Console.WriteLine("{0} {1}", trackLength, turnsCount);
                        break;
                    }

                    x--;
                }
                else
                {
                    if ((x == 0) && (nextDir == n))
                    {
                        Console.WriteLine("No {0}", trackLength);
                        break;
                    }
                    else if ((nextDir == n) && (grid[y - 1][x] == "1"))
                    {
                        Console.WriteLine("No {0}", trackLength);
                        break;
                    }
                    else if ((nextDir == s) && (grid[y + 1][x] == "1"))
                    {
                        Console.WriteLine("No {0}", trackLength);
                        break;
                    }
                    else
                    {
                        turnsCount++;
                        dir = nextDir;

                        if (nextDir == n)
                        {
                            nextDir = s;
                        }
                        else if (nextDir == s)
                        {
                            nextDir = n;
                        }
                    }
                }
            }
            else if (dir == n)
            {
                if ((y > 0) && (grid[y - 1][x] == "0"))
                {
                    trackLength++;
                    y--;
                }
                else if ((y == 0) && (grid[y][x - 1] == "1"))
                {
                    Console.WriteLine("No {0}", trackLength);
                    break;
                }
                else
                {
                    turnsCount++;
                    dir = w;
                }
            }
        }

    }
}