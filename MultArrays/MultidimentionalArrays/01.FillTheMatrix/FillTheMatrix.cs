using System;

class FillTheMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int num = 1;

        if (c == 'a')
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = num++;
                }
            }
        }
        else if (c == 'b')
        {
            bool down = true;
            for (int col = 0; col < n; col++)
            {
                if (down)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = num++;
                    }
                    down = false;
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = num++;
                    }
                    down = true;
                }
            }
        }
        else if (c == 'c')
        {
            for (int row = n - 1, col = 0; col < n;)
            {
                matrix[row, col] = num++;

                for (int startR = row, startC = col; ;)
                {
                    if (((startR + 1) < n) && ((startC + 1) < n))
                    {
                        startR++;
                        startC++;
                        matrix[startR, startC] = num++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (row != 0)
                {
                    row--;
                }
                else
                {
                    col++;
                }
            }
        }
        else if (c == 'd')
        {
            char dir = 'd';
            for (int col = 0, row = 0; num <= (n * n);)
            {
                matrix[row, col] = num++;

                switch (dir)
                {
                    case 'd':
                        if (((row + 1) == n) || (matrix[row + 1, col] != 0))
                        {
                            dir = 'r';
                            col++;
                        }
                        else
                        {
                            row++;
                        }
                        break;
                    case 'r':
                        if (((col + 1) == n) || (matrix[row, col + 1] != 0))
                        {
                            dir = 'u';
                            row--;
                        }
                        else
                        {
                            col++;
                        }
                        break;
                    case 'u':
                        if (((row - 1) == -1) || (matrix[row - 1, col] != 0))
                        {
                            dir = 'l';
                            col--;
                        }
                        else
                        {
                            row--;
                        }
                        break;
                    case 'l':
                        if (((col - 1) == -1) || (matrix[row, col - 1] != 0))
                        {
                            dir = 'd';
                            row++;
                        }
                        else
                        {
                            col--;
                        }
                        break;
                    default:
                        break;
                }
            }
        }


        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == n - 1)
                {
                    Console.Write("{0}", matrix[row, col]);
                    break;
                }

                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

