using System;

class SequenceInMatrix
{
    static void Main(string[] args)
    {
        string inputMatrix = Console.ReadLine();
        int n = int.Parse(inputMatrix.Split(' ')[0]);
        int m = int.Parse(inputMatrix.Split(' ')[1]);
        string[,] matrix = new string[n, m];
        for (int row = 0; row < n; row++)
        {
            string[] inputRow = (Console.ReadLine()).Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }
        int maxSeq = 0;

        for (int row = 0; row < n; row++)
        {
            int currentSeq = 1;
            string currentString = matrix[row, 0];

            for (int col = 1; col < m; col++)
            {
                if (matrix[row, col] == currentString)
                {
                    currentSeq++;
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                    }

                    currentSeq = 1;
                    currentString = matrix[row, col];
                }
            }

            if (currentSeq > maxSeq)
            {
                maxSeq = currentSeq;
            }
        }

        for (int col = 0; col < m; col++)
        {
            int currentSeq = 1;
            string currentString = matrix[0, col];

            for (int row = 1; row < n; row++)
            {
                if (matrix[row, col] == currentString)
                {
                    currentSeq++;
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                    }

                    currentSeq = 1;
                    currentString = matrix[row, col];
                }
            }

            if (currentSeq > maxSeq)
            {
                maxSeq = currentSeq;
            }
        }

        for (int row = 0, col = 0; col < m ;)
        {
            int currentSeq = 1;
            string currentString = matrix[row, col];
            for (int dRow = row, dCol = col; ;)
            {
                if (((dRow - 1) >= 0) && ((dCol + 1) < m))
                {
                    dRow--;
                    dCol++;

                    if (matrix[dRow, dCol] == currentString)
                    {
                        currentSeq++;
                    }
                    else
                    {
                        if (currentSeq > maxSeq)
                        {
                            maxSeq = currentSeq;
                        }

                        currentSeq = 1;
                        currentString = matrix[dRow, dCol];
                    }
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                    }

                    break;
                }
            }

            if (row < n - 1)
            {
                row++;
            }
            else
            {
                col++;
            }
        }

        for (int row = n - 1, col = 0; col < m;)
        {
            int currentSeq = 1;
            string currentString = matrix[row, col];
            for (int dRow = row, dCol = col; ;)
            {
                if (((dRow + 1) < n) && ((dCol + 1) < m))
                {
                    dRow++;
                    dCol++;

                    if (matrix[dRow, dCol] == currentString)
                    {
                        currentSeq++;
                    }
                    else
                    {
                        if (currentSeq > maxSeq)
                        {
                            maxSeq = currentSeq;
                        }

                        currentSeq = 1;
                        currentString = matrix[dRow, dCol];
                    }
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                    }

                    break;
                }
            }

            if (row > 0)
            {
                row--;
            }
            else
            {
                col++;
            }
        }

        Console.WriteLine(maxSeq);
    }
}

