using System;

class Fire
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int heigth = (n / 2) + (n / 4) + 1 + (n / 2);
        char[][] torch = new char[heigth][];
        for (int i = 0; i < heigth; i++)
        {
            torch[i] = new char[n];
            for (int k = 0; k < n; k++)
            {
                torch[i][k] = '.';
            }
        }

        for (int i = 0, start = (n / 2) - 1, end = (n / 2); i < (n / 2) + (n / 4); i++)
        {
            for (int s = start; s <= end; s += (end - start))
            {
                torch[i][s] = '#';
            }

            if (i < (n / 2) - 1)
            {
                start--;
                end++;
            }
            else if (i >= (n / 2))
            {
                start++;
                end--;
            }
        }

        for (int col = 0, row = (n / 2) + (n / 4); col < n; col++)
        {
            torch[row][col] = '-';
        }

        for (int i = (n / 2) + (n / 4) + 1, start = 0, end = n - 1; i < heigth; i++)
        {
            for (int s = start; s <= end; s++)
            {
                if (s < (n / 2))
                {
                    torch[i][s] = '\\';
                }
                else
                {
                    torch[i][s] = '/';
                }
            }

            start++;
            end--;
        }

        for (int i = 0; i < heigth; i++)
        {
            foreach (var item in torch[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

