using System;

class FallDown
{
    static void Main(string[] args)
    {
        int[] rows = new int[8];
        for (int i = 0; i < 8; i++)
        {
            rows[i] = int.Parse(Console.ReadLine());
        }
        int[] resultRows = new int[8];

        int[][] table = new int[8][];
        for (int i = 0; i < 8; i++)
        {
            table[i] = new int[8];

            for (int k = 0; k < 8; k++)
            {
                table[i][k] = 0;
            }
        } // Making 8x8 table filled with zeros

        for (int i = 0; i < 8; i++)
        {
            if (rows[i] != 0)
            {
                for (int num = rows[i], ind = 0; num != 0; num /= 2, ind++)
                {
                    table[i][ind] = num % 2;
                }
            }
        } // Filling the table with values from the input
        
        for (int count = 0; count < 8; count++)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int k = 7, exchangeValue = new int(); k > 0; k--)
                {
                    if ((table[k][i] == 0) && (table[k - 1][i] == 1))
                    {
                        exchangeValue = table[k][i];
                        table[k][i] = table[k - 1][i];
                        table[k - 1][i] = exchangeValue;
                    }
                }
            }
        } // "FallDown" the values

        for (int i = 0; i < 8; i++)
        {
            for (int k = 0, value = new int(); k < 8; k++)
            {
                if (table[i][k] == 1)
                {
                    resultRows[i] += (int)Math.Pow(2, k);
                }
                
            }
        } // Filling the results

        foreach (var item in resultRows)
        {
            Console.WriteLine(item);
        }
    }
}

