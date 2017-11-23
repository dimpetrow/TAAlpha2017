using System;

class MaximalSum
{
    static void Main(string[] args)
    {
        string inputMatrix = "5 5";//Console.ReadLine();
        int n = int.Parse(inputMatrix.Split(' ')[0]);
        int m = int.Parse(inputMatrix.Split(' ')[1]);
        int[,] matrix = new int[n, m];
        for (int row = 0; row < n; row++)
        {
            string[] inputRow = (Console.ReadLine()).Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = int.Parse(inputRow[col]);
            }
        }
        int maximalSquareSum = int.MinValue;

        for (int row = 1; row < n - 1; row++)
        {
            for (int col = 1; col < m - 1; col++)
            {
                int currentSum = 0;

                for (int rowSq = row - 1; rowSq <= row + 1; rowSq++)
                {
                    for (int colSq = col - 1; colSq <= col + 1; colSq++)
                    {
                        currentSum += matrix[rowSq, colSq];
                    }
                }

                if (currentSum > maximalSquareSum)
                {
                    maximalSquareSum = currentSum;
                }
            }
        }

        Console.WriteLine(maximalSquareSum);
    }
}

