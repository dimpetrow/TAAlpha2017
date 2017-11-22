using System;

class AngryBits
{
    static void Main(string[] args)
    {
        int[] rows = { 0, 1, 0, 3632, 3632, 3632, 0, 265 };//new int[8];
        //for (int i = 0; i < 8; i++)
        //{
        //    rows[i] = int.Parse(Console.ReadLine());
        //}

        char[][] grid = new char[8][];
        for (int i = 0; i < 8; i++)
        {
            string row = Convert.ToString(rows[i], 2);
            row = row.PadLeft(16, '0');

            grid[i] = new char[16];
            for (int k = 0; k < 16; k++)
            {
                if (row[k] == '0')
                {
                    grid[i][k] = '0';
                }
                else
                {
                    grid[i][k] = '1';
                }
            }
        } // Store the grid in array

        //for (int i = 0, b = 0; i < 8; i++)
        //{
        //    foreach (var item in grid[i])
        //    {
        //        b++;
        //        Console.Write(item);
        //        if (b == 8)
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    b = 0;
        //    Console.WriteLine();
        //} // Print Grid before the Attack
        //Console.WriteLine();

        int generalScore = 0;
        int score = 0;
        string isGameWon = "Yes";

        for (int i = 7; i >= 0; i--)
        {
            for (int k = 0; k < 8; k++)
            {
                if (grid[k][i] == '1')
                {
                    int row = k;
                    int coll = i;
                    int roof = int.MaxValue;

                    while ((row < 8) && (coll < 16))
                    {
                        if (row == 0)
                        {
                            roof = coll;
                        } // When Bird Hit the Roof -> Starts Falling

                        if (coll >= roof)
                        {
                            row++;
                            coll++;
                        } // Bird is Falling Down
                        else
                        {
                            row--;
                            coll++;
                        } // Bird is Going Up

                        score++; // The Score Increases

                        if ((coll >= 8) && (coll < 16) && (row < 8))
                        {
                            if (grid[row][coll] == '1')
                            {
                                int pigsCount = 1;
                                grid[row][coll] = '0';

                                // Check for Pigs Around
                                if ((row < 7) && (grid[row + 1][coll] == '1'))
                                {
                                    grid[row + 1][coll] = '0';
                                    pigsCount++;
                                }
                                if ((row > 0) && (grid[row - 1][coll] == '1'))
                                {
                                    grid[row - 1][coll] = '0';
                                    pigsCount++;
                                }
                                if ((coll < 15) && ((grid[row][coll + 1] == '1')))
                                {
                                    grid[row][coll + 1] = '0';
                                    pigsCount++;
                                }
                                if ((coll > 8) && ((grid[row][coll - 1] == '1')))
                                {
                                    grid[row][coll - 1] = '0';
                                    pigsCount++;
                                }
                                if (((row > 0) && (coll < 15)) && (grid[row - 1][coll + 1] == '1'))
                                {
                                    grid[row - 1][coll + 1] = '0';
                                    pigsCount++;
                                }
                                if (((row < 7) && (coll < 15)) && (grid[row + 1][coll + 1] == '1'))
                                {
                                    grid[row + 1][coll + 1] = '0';
                                    pigsCount++;
                                }
                                if (((row < 7) && (coll > 8)) && (grid[row + 1][coll - 1] == '1'))
                                {
                                    grid[row + 1][coll - 1] = '0';
                                    pigsCount++;
                                }
                                if (((row > 0) && (coll > 8)) && (grid[row - 1][coll - 1] == '1'))
                                {
                                    grid[row - 1][coll - 1] = '0';
                                    pigsCount++;
                                }

                                score *= pigsCount;
                                generalScore += score;
                                score = 0;
                                break;
                            }
                        } // Find a Pig

                        if ((row == 8) || (coll == 16))
                        {
                            score = 0;
                        } // No Pig Hit (Score reset to zero)
                    } // Bird Starts Flying
                } // Find a Bird
            }
        } // Search Birds in Grid and ATTACK

        for (int i = 0; i < 8; i++)
        {
            for (int k = 8; k < 16; k++)
            {
                if (grid[i][k] == '1')
                {
                    isGameWon = "No";
                }
            }
        } // Search for Piggies after the Attack

        Console.WriteLine(generalScore + " " + isGameWon);

        //Console.WriteLine();
        //for (int i = 0,b = 0; i < 8; i++)
        //{
        //    foreach (var item in grid[i])
        //    {
        //        b++;
        //        Console.Write(item);
        //        if (b == 8)
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    b = 0;
        //    Console.WriteLine();
        //} // Print Grid after the Attack
    }
}

