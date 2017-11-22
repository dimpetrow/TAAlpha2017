using System;

class FirTree
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int width = 5 + ((n - 4) * 2);
        string[][] tree = new string[n][];
        for (int i = 0; i < n; i++)
        {
            tree[i] = new string[width];
            for (int k = 0; k < width; k++)
            {
                tree[i][k] = ".";
            }
        }

        for (int i = 0, start = (width / 2), end = (width / 2); i < n - 1; i++, start -= 1, end += 1)
        {
            for (int k = start; k <= end; k++)
            {
                tree[i][k] = "*";
            }

            if (i == n - 2)
            {
                tree[n - 1][width / 2] = "*";
            }
        }

        for (int i = 0; i < n; i++)
        {
            foreach (var item in tree[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

