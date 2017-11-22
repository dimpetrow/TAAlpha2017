using System;

class Lines
{
    static void Main(string[] args)
    {
        int[] rows = { 8, 72, 8, 8, 16, 28, 240, 0 }; //new int[8];
        //for (int i = 0; i < 8; i++)
        //{
        //    rows[i] = int.Parse(Console.ReadLine());
        //}
        string[][] grid = new string[8][];
        for (int i = 0; i < 8; i++)
        {
            grid[i] = new string[8];
        } // Make grid in array

        for (int i = 0; i < 8; i++)
        {
            string str = Convert.ToString(rows[i], 2);
            str = str.PadLeft(8, '0');

            for (int k = 0; k < 8; k++)
            {
                grid[i][k] = str[8 - k - 1].ToString();
            }
        } // Fill the grid with the input

        int maxLineLength = 0;
        int maxLineCount = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int k = 0, lineLength = 0; k < 8; k++)
            {
                if (grid[i][k] == "1")
                {
                    lineLength++;
                    if (lineLength > maxLineLength)
                    {
                        maxLineLength = lineLength;
                        maxLineCount = 0;
                    }
                }
                else if (lineLength != 0)
                {
                    if (lineLength == maxLineLength)
                    {
                        maxLineCount++;
                    }
                    lineLength = 0;
                }

                if ((k == 7) && (lineLength != 0))
                {
                    if (lineLength == maxLineLength)
                    {
                        maxLineCount++;
                    }
                }
            }
        } // Rows scan

        for (int i = 0; i < 8; i++)
        {
            for (int k = 0, lineLength = 0; k < 8; k++)
            {
                if (grid[k][i] == "1")
                {
                    lineLength++;
                    if (lineLength > maxLineLength)
                    {
                        maxLineLength = lineLength;
                        maxLineCount = 0;
                    }
                }
                else if (lineLength != 0)
                {
                    if (lineLength == maxLineLength)
                    {
                        maxLineCount++;
                    }
                    lineLength = 0;
                }

                if ((k == 7) && (lineLength != 0))
                {
                    if (lineLength == maxLineLength)
                    {
                        maxLineCount++;
                    }
                }
            }
        } // Columns scan

        Console.WriteLine(maxLineLength);
        Console.WriteLine(maxLineCount);
    }
}

