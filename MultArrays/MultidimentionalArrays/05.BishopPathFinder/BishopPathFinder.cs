using System;

class BishopPathFinder
{
    static void Main(string[] args)
    {
        string dimentions = Console.ReadLine();
        int r = int.Parse(dimentions.Split(' ')[0]);
        int c = int.Parse(dimentions.Split(' ')[1]);
        int n = int.Parse(Console.ReadLine());

        int startR = r - 1;
        int startC = 0;

        int sum = 0;

        int?[,] chessBoard = new int?[r, c];

        for (int row = r - 1, startValue = 0; row >= 0; row--, startValue += 3)
        {
            for (int col = 0, value = startValue; col < c; col++, value += 3)
            {
                chessBoard[row, col] = value;
            }
        } //Fill ChessBoard


        for (int instr = 0; instr < n; instr++)
        {
            string dK = Console.ReadLine();
            string dir = dK.Split(' ')[0];
            int moves = int.Parse(dK.Split(' ')[1]);

            if (dir == "RU" || dir == "UR")
            {
                int endRow = startR - (moves - 1);
                int endCol = startC + moves - 1;

                while (true)
                {
                    if (((startR >= 0) && (startC < c)) && chessBoard[startR, startC] != null)
                    {
                        sum += (int)chessBoard[startR, startC];
                        chessBoard[startR, startC] = null;
                    }

                    if ((startR == endRow) && (startC == endCol))
                    {
                        break;
                    }

                    if (!(startR - 1 < 0) && !(startC + 1 == c))
                    {
                        startR--;
                        startC++;
                    }
                    else
                    {
                        break;
                    }


                }
            }
            else if (dir == "LU" || dir == "UL")
            {
                int endRow = startR - (moves - 1);
                int endCol = startC - (moves - 1);

                while (true)
                {
                    if (((startR >= 0) && (startC >= 0)) && chessBoard[startR, startC] != null)
                    {
                        sum += (int)chessBoard[startR, startC];
                        chessBoard[startR, startC] = null;
                    }

                    if ((startR == endRow) && (startC == endCol))
                    {
                        break;
                    }

                    if (!(startR - 1 < 0) && !(startC - 1 < 0))
                    {
                        startR--;
                        startC--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (dir == "DL" || dir == "LD")
            {
                int endRow = startR + moves - 1;
                int endCol = startC - (moves - 1);

                while (true)
                {
                    if (((startR < r) && (startC >= 0)) && chessBoard[startR, startC] != null)
                    {
                        sum += (int)chessBoard[startR, startC];
                        chessBoard[startR, startC] = null;
                    }

                    if ((startR == endRow) && (startC == endCol))
                    {
                        break;
                    }

                    if (!(startR + 1 == r) && !(startC - 1 < 0))
                    {
                        startR++;
                        startC--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (dir == "RD" || dir == "DR")
            {
                int endRow = startR + moves - 1;
                int endCol = startC + moves - 1;

                while (true)
                {
                    if (((startR < r) && (startC < c)) && chessBoard[startR, startC] != null)
                    {
                        sum += (int)chessBoard[startR, startC];
                        chessBoard[startR, startC] = null;
                    }

                    if ((startR == endRow) && (startC == endCol))
                    {
                        break;
                    }

                    if (!(startR + 1 == r) && !(startC + 1 == c))
                    {
                        startR++;
                        startC++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        Console.WriteLine(sum);
    }
}


