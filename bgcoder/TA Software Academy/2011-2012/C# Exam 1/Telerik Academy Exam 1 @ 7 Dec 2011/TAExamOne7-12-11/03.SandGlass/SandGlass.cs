using System;

class SandGlass
{
    static void Main(string[] args)
    {
        int n = 31;//int.Parse(Console.ReadLine());
        string[][] sandGlass = new string[n][];
        for (int i = 0; i < n; i++)
        {
            sandGlass[i] = new string[n];
            for (int k = 0; k < n; k++)
            {
                sandGlass[i][k] = ".";
            }
        }

        for (int i = 0,start = 0, end = n - 1; i < n; i++)
        {
            for (int k = start; k <= end; k++)
            {
                sandGlass[i][k] = "*";
            }

            if (i < n / 2)
            {
                start++;
                end--;
            }
            else
            {
                start--;
                end++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            foreach (var item in sandGlass[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

