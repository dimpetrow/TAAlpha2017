using System;

class BullsAndCows
{
    static void Main(string[] args)
    {
        int secretNum = 1234;//int.Parse(Console.ReadLine());
        string secretStr = secretNum.ToString();
        int bulls = 0;//int.Parse(Console.ReadLine());
        int cows = 3;//int.Parse(Console.ReadLine()); 
        char[] guessNum = { '1', '1', '1', '1' };

        int checkBulls = 0;
        int checkCows = 0;

        bool match = false;

        while (guessNum[0] != '0')
        {
            int[] bullPositions = { -1, -1, -1, -1 };
            int[] cowPositions = { -1, -1, -1, -1 }; // Array indexes will never get to -1 ;)

            for (int i = 0; i < 4; i++)
            {
                if (secretStr[i] == guessNum[i])
                {
                    checkBulls++;
                    bullPositions[i] = i;

                }
            } // Check for Bulls

            if (checkBulls == bulls)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == bullPositions[i])
                    {
                        continue;
                    }

                    for (int k = 0; k < 4; k++)
                    {
                        if (k == i)
                        {
                            continue;
                        }

                        if (k == cowPositions[k])
                        {
                            continue;
                        }

                        if (k == bullPositions[k])
                        {
                            continue;
                        }

                        if (secretStr[i] == guessNum[k])
                        {
                            checkCows++;
                            cowPositions[k] = k;
                            break;
                        }
                    }
                } // Check for Cows

                if (checkCows == cows)
                {
                    Console.Write(guessNum[0].ToString() + guessNum[1].ToString() + guessNum[2].ToString() + guessNum[3].ToString() + " ");

                    if (match == false)
                    {
                        match = true;
                    }
                }

                checkCows = 0;
                checkBulls = 0;
            }
            else
            {
                checkBulls = 0;
            } // Check Bulls Count

            if (guessNum[3] == '9')
            {
                guessNum[3] = '1';

                if (guessNum[2] == '9')
                {
                    guessNum[2] = '1';

                    if (guessNum[1] == '9')
                    {
                        guessNum[1] = '1';

                        if (guessNum[0] == '9')
                        {
                            guessNum[0] = '0';
                        }
                        else
                        {
                            guessNum[0] += (char)1;
                        }
                    }
                    else
                    {
                        guessNum[1] += (char)1;
                    }
                }
                else
                {
                    guessNum[2] += (char)1;
                }
            }
            else
            {
                guessNum[3] += (char)1;
            }
        }

        Console.WriteLine(match ? "" : "No");
    }
}

