using System;

class UKFlag
{
    static void Main(string[] args)
    {
        int n = 116;//int.Parse(Console.ReadLine());
        char[][] flag = new char[n][];
        for (int i = 0; i < n; i++)
        {
            flag[i] = new char[n];
            for (int k = 0; k < n; k++)
            {
                flag[i][k] = '.';
            }
        }
        

        for (int i = 0, left = 0, middle = n / 2, right = n - 1; i < n; i++)
        {
            if (i < n / 2)
            {
                flag[i][left] = '\\';
                flag[i][middle] = '|';
                flag[i][right] = '/';

                if (i == (n/2) - 1)
                {
                    continue;
                }

                left++;
                right--;
            }
            else if (i == n / 2)
            {
                for (int k = 0; k < n; k++)
                {
                    if (k == n / 2)
                    {
                        flag[i][k] = '*';
                        continue;
                    }
                    flag[i][k] = '-';
                }
            }
            else if (i > n / 2)
            {
                flag[i][left] = '/';
                flag[i][middle] = '|';
                flag[i][right] = '\\';

                left--;
                right++;
            }
        }


        for (int i = 0; i < n; i++)
        {
            foreach (var item in flag[i])
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}

