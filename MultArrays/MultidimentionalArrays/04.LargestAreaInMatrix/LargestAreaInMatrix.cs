using System;
using System.Collections.Generic;

class LargestAreaInMatrix
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n = int.Parse(input.Split(' ')[0]);
        int m = int.Parse(input.Split(' ')[1]);
        int?[,] matrix = new int?[n, m];
        for (int row = 0; row < n; row++)
        {
            string[] inputRow = (Console.ReadLine()).Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = int.Parse(inputRow[col]);
            }
        }
        //Read Matrix

        List<int> stackRows = new List<int>();
        List<int> stackCols = new List<int>();
        List<string> comeFrom = new List<string>();
        string notGoingThere = "";

        int maxAreaEquals = 1;


        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < m; c++)
            {
                if (matrix[r, c] != null)
                {
                    stackRows.Add(r);
                    stackCols.Add(c);
                    comeFrom.Add(notGoingThere);

                    int curR = r;
                    int curC = c;
                    int? currentEl = matrix[curR, curC];
                    bool hasEquals = true;

                    int currentMax = 1;


                    while (hasEquals)
                    {
                        if ((curC + 1 < m) && (currentEl == matrix[curR, curC + 1]) && (comeFrom[comeFrom.Count - 1] != "right"))
                        {
                            curC++;
                            notGoingThere = "left";
                            comeFrom.Add(notGoingThere);

                            currentMax++;

                            stackRows.Add(curR);
                            stackCols.Add(curC);

                            continue;
                        }
                        //Check Equal Right

                        if ((curR + 1 < n) && (currentEl == matrix[curR + 1, curC]) && (comeFrom[comeFrom.Count - 1] != "down"))
                        {
                            curR++;
                            notGoingThere = "up";
                            comeFrom.Add(notGoingThere);

                            currentMax++;

                            stackRows.Add(curR);
                            stackCols.Add(curC);

                            continue;
                        }
                        //Check Equal Down

                        if ((curC - 1 >= 0) && (currentEl == matrix[curR, curC - 1]) && (comeFrom[comeFrom.Count - 1] != "left"))
                        {
                            curC--;
                            notGoingThere = "right";
                            comeFrom.Add(notGoingThere);

                            currentMax++;

                            stackRows.Add(curR);
                            stackCols.Add(curC);

                            continue;
                        }
                        //Check Equal Left

                        if ((curR - 1 >= 0) && (currentEl == matrix[curR - 1, curC]) && (comeFrom[comeFrom.Count - 1] != "up"))
                        {
                            curR--;
                            notGoingThere = "down";
                            comeFrom.Add(notGoingThere);

                            currentMax++;

                            stackRows.Add(curR);
                            stackCols.Add(curC);

                            continue;
                        }
                        //Check Equal Up
                        

                        stackRows.RemoveAt(stackRows.Count - 1);
                        stackCols.RemoveAt(stackCols.Count - 1);

                        matrix[curR, curC] = null;


                        if (stackRows.Count != 0)
                        {
                            curR = stackRows[stackRows.Count - 1];
                            curC = stackCols[stackCols.Count - 1];
                        }
                        else
                        {
                            hasEquals = false;
                        }
                        comeFrom.RemoveAt(comeFrom.Count - 1);
                    }

                    if (currentMax > maxAreaEquals)
                    {
                        maxAreaEquals = currentMax;
                    }
                }
            }
        }

        Console.WriteLine(maxAreaEquals);
    }
}

