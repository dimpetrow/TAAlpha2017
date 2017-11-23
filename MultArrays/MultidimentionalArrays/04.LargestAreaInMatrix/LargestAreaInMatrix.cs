using System;
using System.Collections.Generic;

class LargestAreaInMatrix
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n = int.Parse(input.Split(' ')[0]);
        int m = int.Parse(input.Split(' ')[1]);
        string[,] matrix = new string[n, m];
        bool[,] visited = new bool[n,m]; // Visited Elements
        for (int row = 0; row < n; row++)
        {
            string[] inputRow = (Console.ReadLine()).Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }
        //Read Matrix

        List<int> stackRows = new List<int>();
        List<int> stackCols = new List<int>();

        int maxAreaEquals = 1;


        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < m; c++)
            {
                if (!visited[r, c])
                {
                    visited[r, c] = true;
                    stackRows.Add(r);
                    stackCols.Add(c);

                    int curR = r;
                    int curC = c;
                    string currentEl = matrix[curR, curC];
                    bool hasEquals = true;

                    int currentMax = 1;


                    while (hasEquals)
                    {
                        if ((curC + 1 < m) && (currentEl == matrix[curR, curC + 1]) && !visited[curR, curC + 1])
                        {
                            curC++;

                            visited[curR, curC] = true;
                            currentMax++;

                            stackRows.Add(curR);
                            stackCols.Add(curC);

                            continue;
                        }
                        //Check Equal Right

                        if ((curR + 1 < n) && (currentEl == matrix[curR + 1, curC]) && !visited[curR + 1, curC])
                        {
                            curR++;

                            visited[curR, curC] = true;
                            currentMax++;

                            stackRows.Add(curR);
                            stackCols.Add(curC);
                            
                            continue;
                        }
                        //Check Equal Down

                        if ((curC - 1 >= 0) && (currentEl == matrix[curR, curC - 1]) && !visited[curR, curC - 1])
                        {
                            curC--;

                            visited[curR, curC] = true;
                            currentMax++;

                            stackRows.Add(curR);
                            stackCols.Add(curC);

                            continue;
                        }
                        //Check Equal Left

                        if ((curR - 1 >= 0) && (currentEl == matrix[curR - 1, curC]) && !visited[curR - 1, curC])
                        {
                            curR--;

                            visited[curR, curC] = true;
                            currentMax++;

                            stackRows.Add(curR);
                            stackCols.Add(curC);

                            continue;
                        }
                        //Check Equal Up


                        stackRows.RemoveAt(stackRows.Count - 1);
                        stackCols.RemoveAt(stackCols.Count - 1);

                        if (stackRows.Count != 0)
                        {
                            curR = stackRows[stackRows.Count - 1];
                            curC = stackCols[stackCols.Count - 1];
                        }
                        else
                        {
                            hasEquals = false;
                        }
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

