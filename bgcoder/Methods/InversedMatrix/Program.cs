using System;
using System.Numerics;

namespace InversedMatrix
{
    class Program
    {
        static int n;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            string[][] matA = new string[n][];
            for (int r = 0; r < n; r++)
            {
                string[] row = (Console.ReadLine()).Split(' ');
                matA[r] = new string[n];
                for (int c = 0; c < n; c++)
                {
                    matA[r][c] = row[c];
                }
            }

            Console.WriteLine();

            string[][] matB = new string[n][];
            for (int r = 0; r < n; r++)
            {
                string[] row = (Console.ReadLine()).Split(' ');
                matB[r] = new string[1];
                matB[r][0] = row[0];
            }
            
            Console.WriteLine();
            Console.WriteLine("A, B, C");
            PrintMatrix(matA);
            Console.WriteLine();
            PrintMatrix(matB);

            string[][] matA1 = InverseMatrix(matA);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A-1");

            PrintMatrix(matA1);
            Console.WriteLine();

            string[][] a1B = MultiplyMatrix(matA1, matB);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A-1xB");
            Console.WriteLine();
            PrintMatrix(a1B);
        }

        private static string[][] InverseMatrix(string[][] matrix)
        {
            string[][] matrixE = new string[n][];
            for (int r = 0, valuePos = n; r < n; r++, valuePos++)
            {
                matrixE[r] = new string[n + n];
                for (int c = 0; c < matrixE[r].Length; c++)
                {
                    if (c < n)
                    {
                        matrixE[r][c] = matrix[r][c].ToString();
                    }
                    else if (c == valuePos)
                    {
                        matrixE[r][c] = "1";
                    }
                    else
                    {
                        matrixE[r][c] = "0";
                    }
                }
            }

            for (int col = 0, startRow = 0; col < n; col++, startRow++)
            {
                for (int row = startRow + 1; row < n; row++)
                {
                    string exprForZeroResult;

                    if (matrixE[row][col] == "0" || matrixE[startRow][col] == "0")
                    {
                        exprForZeroResult = "0";
                    }
                    else
                    {
                        exprForZeroResult = "-" + ComFracAction(matrixE[row][col], matrixE[startRow][col], '/');
                    }

                    for (int c = 0; c < n + n; c++)
                    {
                        if (!(matrixE[startRow][c] == "0" || exprForZeroResult == "0"))
                        {
                            string addend = ComFracAction(exprForZeroResult, matrixE[startRow][c], '*');
                            matrixE[row][c] = ComFracAction(matrixE[row][c], addend, '+');
                        }
                    }
                }
            } // Clear matrix below primary diagonal

            for (int col = n - 1, startRow = n - 1; col >= 0; col--, startRow--)
            {
                for (int row = startRow - 1; row >= 0; row--)
                {
                    string exprForZeroResult;

                    if (matrixE[row][col] == "0" || matrixE[startRow][col] == "0")
                    {
                        exprForZeroResult = "0";
                    }
                    else
                    {
                        exprForZeroResult = "-" + ComFracAction(matrixE[row][col], matrixE[startRow][col], '/');

                        if (exprForZeroResult.Length > 1 && exprForZeroResult[1] == '-')
                        {
                            string newStr = "";
                            for (int i = 2; i < exprForZeroResult.Length; i++)
                            {
                                newStr += exprForZeroResult[i];
                            }
                            exprForZeroResult = newStr;
                        }

                    }

                    for (int c = n + n - 1; c >= 0; c--)
                    {
                        if (!(matrixE[startRow][c] == "0" || exprForZeroResult == "0"))
                        {
                            string addend = ComFracAction(exprForZeroResult, matrixE[startRow][c], '*');
                            matrixE[row][c] = ComFracAction(matrixE[row][c], addend, '+');
                        }
                    }
                }
            } // Clear matrix above primary diagonal

            for (int r = 0, c = 0; r < n; r++, c++)
            {
                string exprForOneResult = ComFracAction("1", matrixE[r][c], '/');

                for (int col = 0; col < n + n; col++)
                {
                    if (!(matrixE[r][col] == "0"))
                    {
                        matrixE[r][col] = ComFracAction(matrixE[r][col], exprForOneResult, '*');
                    }
                }
            } // Make primary diagonal only of Ones

            string[][] invMat = new string[n][];
            for (int r = 0; r < n; r++)
            {
                invMat[r] = new string[n];
                for (int c = 0; c < n; c++)
                {
                    invMat[r][c] = matrixE[r][c + n];
                }
            }

            return invMat;
        }

        private static string ComFracAction(string fracOne, string fracTwo, char action)
        {
            string comFrac = "";
            string numOne = "";
            string denomOne = "";
            bool denom = false;
            for (int dig = 0; dig < fracOne.Length; dig++)
            {
                if (fracOne[dig] == '/')
                {
                    denom = true;
                    dig++;
                }

                if (denom)
                {
                    denomOne += fracOne[dig];
                }
                else
                {
                    numOne += fracOne[dig];
                }
            }
            if (!denom)
            {
                denomOne = "1";
            }

            string numTwo = "";
            string denomTwo = "";
            denom = false;
            for (int dig = 0; dig < fracTwo.Length; dig++)
            {
                if (fracTwo[dig] == '/')
                {
                    denom = true;
                    dig++;
                }

                if (denom)
                {
                    denomTwo += fracTwo[dig];
                }
                else
                {
                    numTwo += fracTwo[dig];
                }
            }
            if (!denom)
            {
                denomTwo = "1";
            }

            if (numOne.Length > 1 && numOne[1] == '-')
            {
                string newStr = "";
                for (int i = 1; i < numOne.Length; i++)
                {
                    newStr += numOne[i];
                }
                numOne = newStr;
            }
            if (numTwo.Length > 1 && numTwo[1] == '-')
            {
                string newStr = "";
                for (int i = 1; i < numTwo.Length; i++)
                {
                    newStr += numTwo[i];
                }
                numTwo = newStr;
            }

            int num = new int();
            int denomin = new int();

            switch (action)
            {
                case '+':
                    num = (int.Parse(numOne) * int.Parse(denomTwo)) + (int.Parse(denomOne) * int.Parse(numTwo));
                    denomin = int.Parse(denomOne) * int.Parse(denomTwo);

                    if (Math.Abs(num) > Math.Abs(denomin))
                    {
                        int theBiggestDiv = (int)((num >= 0) ? Math.Sqrt(num) : Math.Sqrt(-num)) + 1;
                        for (int divisor = 2; divisor <= Math.Abs(num);)
                        {
                            if (num % divisor == 0 && denomin % divisor == 0)
                            {
                                num /= divisor;
                                denomin /= divisor;
                            }
                            else
                            {
                                if (divisor == theBiggestDiv && divisor > denomin)
                                {
                                    if (theBiggestDiv == Math.Abs(num))
                                    {
                                        break;
                                    }


                                    divisor = Math.Abs(denomin);
                                }
                                else
                                {
                                    divisor++;
                                }
                            }
                        }
                    }
                    else
                    {
                        int theBiggestDiv = (int)((denomin >= 0) ? Math.Sqrt(denomin) : Math.Sqrt(-denomin)) + 1;
                        for (int divisor = 2; divisor <= Math.Abs(denomin);)
                        {
                            if (num % divisor == 0 && denomin % divisor == 0)
                            {
                                num /= divisor;
                                denomin /= divisor;
                            }
                            else
                            {
                                if (divisor == theBiggestDiv && divisor > num)
                                {
                                    if (theBiggestDiv == Math.Abs(denomin))
                                    {
                                        break;
                                    }


                                    divisor = Math.Abs(num);
                                }
                                else
                                {
                                    divisor++;
                                }
                            }
                        }
                    }
                    break;
                case '-':
                    num = (int.Parse(numOne) * int.Parse(denomTwo)) - (int.Parse(denomOne) * int.Parse(numTwo));
                    denomin = int.Parse(denomOne) * int.Parse(denomTwo);

                    if (Math.Abs(num) > Math.Abs(denomin))
                    {
                        int theBiggestDiv = (int)((num >= 0) ? Math.Sqrt(num) : Math.Sqrt(-num)) + 1;
                        for (int divisor = 2; divisor <= Math.Abs(num);)
                        {
                            if (num % divisor == 0 && denomin % divisor == 0)
                            {
                                num /= divisor;
                                denomin /= divisor;
                            }
                            else
                            {
                                if (divisor == theBiggestDiv && divisor > denomin)
                                {
                                    if (theBiggestDiv == Math.Abs(num))
                                    {
                                        break;
                                    }


                                    divisor = Math.Abs(denomin);
                                }
                                else
                                {
                                    divisor++;
                                }
                            }
                        }
                    }
                    else
                    {
                        int theBiggestDiv = (int)((denomin >= 0) ? Math.Sqrt(denomin) : Math.Sqrt(-denomin)) + 1;
                        for (int divisor = 2; divisor <= Math.Abs(denomin);)
                        {
                            if (num % divisor == 0 && denomin % divisor == 0)
                            {
                                num /= divisor;
                                denomin /= divisor;
                            }
                            else
                            {
                                if (divisor == theBiggestDiv && divisor > num)
                                {
                                    if (theBiggestDiv == Math.Abs(denomin))
                                    {
                                        break;
                                    }


                                    divisor = Math.Abs(num);
                                }
                                else
                                {
                                    divisor++;
                                }
                            }
                        }
                    }
                    break;
                case '*':
                    num = int.Parse(numOne) * int.Parse(numTwo);
                    denomin = int.Parse(denomOne) * int.Parse(denomTwo);

                    if (Math.Abs(num) > Math.Abs(denomin))
                    {
                        int theBiggestDiv = (int)((num >= 0) ? Math.Sqrt(num) : Math.Sqrt(-num)) + 1;
                        for (int divisor = 2; divisor <= Math.Abs(num);)
                        {
                            if (num % divisor == 0 && denomin % divisor == 0)
                            {
                                num /= divisor;
                                denomin /= divisor;
                            }
                            else
                            {
                                if (divisor == theBiggestDiv && divisor > denomin)
                                {
                                    if (theBiggestDiv == Math.Abs(num))
                                    {
                                        break;
                                    }


                                    divisor = Math.Abs(denomin);
                                }
                                else
                                {
                                    divisor++;
                                }
                            }
                        }
                    }
                    else
                    {
                        int theBiggestDiv = (int)((denomin >= 0) ? Math.Sqrt(denomin) : Math.Sqrt(-denomin)) + 1;
                        for (int divisor = 2; divisor <= Math.Abs(denomin);)
                        {
                            if (num % divisor == 0 && denomin % divisor == 0)
                            {
                                num /= divisor;
                                denomin /= divisor;
                            }
                            else
                            {
                                if (divisor == theBiggestDiv && divisor > num)
                                {
                                    if (theBiggestDiv == Math.Abs(denomin))
                                    {
                                        break;
                                    }


                                    divisor = Math.Abs(num);
                                }
                                else
                                {
                                    divisor++;
                                }
                            }
                        }
                    }
                    break;
                case '/':
                    num = int.Parse(numOne) * int.Parse(denomTwo);
                    denomin = int.Parse(denomOne) * int.Parse(numTwo);

                    if (Math.Abs(num) > Math.Abs(denomin))
                    {
                        int theBiggestDiv = (int)((num >= 0) ? Math.Sqrt(num) : Math.Sqrt(-num)) + 1;
                        for (int divisor = 2; divisor <= Math.Abs(num);)
                        {
                            if (num % divisor == 0 && denomin % divisor == 0)
                            {
                                num /= divisor;
                                denomin /= divisor;
                            }
                            else
                            {
                                if (divisor == theBiggestDiv && divisor > denomin)
                                {
                                    if (theBiggestDiv == Math.Abs(num))
                                    {
                                        break;
                                    }


                                    divisor = Math.Abs(denomin);
                                }
                                else
                                {
                                    divisor++;
                                }
                            }
                        }
                    }
                    else
                    {
                        int theBiggestDiv = (int)((denomin >= 0) ? Math.Sqrt(denomin) : Math.Sqrt(-denomin)) + 1;
                        for (int divisor = 2; divisor <= Math.Abs(denomin);)
                        {
                            if (num % divisor == 0 && denomin % divisor == 0)
                            {
                                num /= divisor;
                                denomin /= divisor;
                            }
                            else
                            {
                                if (divisor == theBiggestDiv && divisor > num)
                                {
                                    if (theBiggestDiv == Math.Abs(denomin))
                                    {
                                        break;
                                    }


                                    divisor = Math.Abs(num);
                                }
                                else
                                {
                                    divisor++;
                                }
                            }
                        }
                    }
                    break;

                default:
                    break;
            }

            if (num == 0)
            {
                comFrac += num.ToString();
            }
            else if (denomin < 0)
            {
                num *= -1;
                denomin *= -1;
                comFrac += num.ToString() + ((denomin != 1) ? '/' + denomin.ToString() : "");
            }
            else
            {
                comFrac += num.ToString() + ((denomin != 1) ? '/' + denomin.ToString() : "");
            }

            return comFrac;
        }

        private static string[][] MultiplyMatrix(string[][] matOne, string[][] matTwo)
        {
            int colsFirst = matOne[0].Length;
            int rowsSecond = matTwo.Length;

            int rows = matOne.Length;
            int cols = matTwo[0].Length;
            string[][] resultMatrix = new string[rows][];
            for (int r = 0; r < rows; r++)
            {
                resultMatrix[r] = new string[cols];
                for (int c = 0; c < cols; c++)
                {
                    resultMatrix[r][c] = "0";
                }
            }

            if (colsFirst != rowsSecond)
            {
                Console.WriteLine("Enter Matrix in format: A(m, n) B(n, p)");
                return resultMatrix;
            }

            int row = 0;
            int col = 0;

            for (int rF = 0; rF < matOne.Length; rF++)
            {
                for (int cS = 0; cS < matTwo[0].Length; cS++)
                {
                    for (int cF = 0, rS = 0; cF < matOne[0].Length; cF++, rS++)
                    {
                        if (!(matOne[rF][cF] == "0" || matTwo[rS][cS] == "0"))
                        {
                            string addend = ComFracAction(matOne[rF][cF], matTwo[rS][cS], '*');
                            resultMatrix[row][col] = ComFracAction(resultMatrix[row][col], addend, '+');
                        }
                    }

                    if (col < cols - 1)
                    {
                        col++;
                    }
                    else
                    {
                        row++;
                        col = 0;
                    }
                }
            }

            return resultMatrix;
        }

        private static double[][] MakeMatrix(int rows, int cols)
        {
            Random number = new Random();

            double[][] mat = new double[rows][];
            for (int r = 0; r < rows; r++)
            {
                mat[r] = new double[cols];
                for (int c = 0; c < cols; c++)
                {
                    mat[r][c] = number.Next(-20, 20);
                }
            }

            return mat;
        }

        private static void PrintMatrix(object[][] matrix)
        {
            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[r].Length; c++)
                {
                    Console.Write("{0,10:f2}", matrix[r][c]);
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static double[] StringToDoubleArr(string[] strInts)
        {
            int n = strInts.Length;
            double[] intArr = new double[n];

            for (int i = 0; i < n; i++)
            {
                intArr[i] = double.Parse(strInts[i]);
            }

            return intArr;
        }

        private static string DecimalToCommonFraction(double decFrac)
        {
            string decFracStr = decFrac.ToString();
            string numerator = "";
            string denominator = "1";
            bool decPart = false;
            for (int i = 0; i < decFracStr.Length; i++)
            {
                if (decFracStr[i] == '.')
                {
                    decPart = true;
                    i++;
                }

                if (decPart)
                {
                    numerator += decFracStr[i];
                    denominator += '0';
                }
                else
                {
                    numerator += decFracStr[i];
                }
            }

            BigInteger num = BigInteger.Parse(numerator);
            BigInteger denom = BigInteger.Parse(denominator);

            for (int divisor = 2; divisor < 100;)
            {
                if (num % divisor == 0 && denom % divisor == 0)
                {
                    num /= divisor;
                    denom /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            numerator = num.ToString();
            denominator = denom.ToString();

            string comFrac = numerator + "/" + denominator;

            return comFrac;
        }

        private static string ComFrac(int num, int denom)
        {
            for (int divisor = 2; divisor < Math.Sqrt(num);)
            {
                if (num % divisor == 0 && denom % divisor == 0)
                {
                    num /= divisor;
                    denom /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            string numerator = num.ToString();
            string denominator = denom.ToString();

            string comFrac = numerator + '/' + denominator;

            return comFrac;
        }
    }
}
