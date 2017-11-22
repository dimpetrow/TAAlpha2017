using System;

class CardWars
{
    static void Main(string[] args)
    {
        int n = 1;//int.Parse(Console.ReadLine());
        string[][] cardsDrawn = new string[1][];//new string[n][];
        cardsDrawn[0] = new string[6] { "4", "10", "J", "10", "4", "4" };
        //for (int i = 0; i < n; i++)
        //{
        //    cardsDrawn[i] = new string[6];
        //    for (int k = 0; k < 6; k++)
        //    {
        //        cardsDrawn[i][k] = Console.ReadLine();
        //    }
        //}

        int playerOneScore = 0;
        int playerOneGamesWon = 0;

        int playerTwoScore = 0;
        int playerTwoGamesWon = 0;

        bool isXCardDrawn = false;


        for (int i = 0; i < n; i++)
        {
            if (((cardsDrawn[i][0] == "X") || (cardsDrawn[i][1] == "X") || (cardsDrawn[i][2] == "X")) && ((cardsDrawn[i][3] == "X") || (cardsDrawn[i][4] == "X") || (cardsDrawn[i][5] == "X")))
            {
                playerOneScore += 50;
                playerTwoScore += 50;
            }
            else if ((cardsDrawn[i][0] == "X") || (cardsDrawn[i][1] == "X") || (cardsDrawn[i][2] == "X"))
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                isXCardDrawn = true;
                break;
            }
            else if ((cardsDrawn[i][3] == "X") || (cardsDrawn[i][4] == "X") || (cardsDrawn[i][5] == "X"))
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                isXCardDrawn = true;
                break;
            }
            // Check for X Card Drawn

            if ((cardsDrawn[i][0] == "Z") || (cardsDrawn[i][1] == "Z") || (cardsDrawn[i][2] == "Z"))
            {
                for (int count = 0,mult = 2; count < 3; count++)
                {
                    if (cardsDrawn[i][count] == "Z")
                    {
                        playerOneScore *= mult;
                        mult *= 2;
                    }
                }
            }
            if ((cardsDrawn[i][3] == "Z") || (cardsDrawn[i][4] == "Z") || (cardsDrawn[i][5] == "Z"))
            {
                for (int count = 3, mult = 2; count < 6; count++)
                {
                    if (cardsDrawn[i][count] == "Z")
                    {
                        playerTwoScore *= mult;
                        mult *= 2;
                    }
                }
            }
            // Check for Z Card Drawn

            if ((cardsDrawn[i][0] == "Y") || (cardsDrawn[i][1] == "Y") || (cardsDrawn[i][2] == "Y"))
            {
                int yTimes = 0;
                for (int count = 0; count < 3; count++)
                {
                    if (cardsDrawn[i][count] == "Y")
                    {
                        yTimes++;
                    }
                }
                playerOneScore -= (200 * yTimes);
            }
            if ((cardsDrawn[i][3] == "Y") || (cardsDrawn[i][4] == "Y") || (cardsDrawn[i][5] == "Y"))
            {
                int yTimes = 0;
                for (int count = 3; count < 6; count++)
                {
                    if (cardsDrawn[i][count] == "Y")
                    {
                        yTimes++;
                    }
                }
                playerTwoScore -= (200 * yTimes);
            }
            // Check for Y Card Drawn

            int[] cards = new int[6];
            int playerOneCurrScore = 0;
            int playerTwoCurrScore = 0;
            for (int ind = 0; ind < 6; ind++)
            {
                if ( (cardsDrawn[i][ind] == "X") || (cardsDrawn[i][ind] == "Z") || (cardsDrawn[i][ind] == "Y") )
                {
                    continue;
                }

                switch (cardsDrawn[i][ind])
                {
                    case "2":
                        cards[ind] = 10;
                        break;
                    case "3":
                        cards[ind] = 9;
                        break;
                    case "4":
                        cards[ind] = 8;
                        break;
                    case "5":
                        cards[ind] = 7;
                        break;
                    case "6":
                        cards[ind] = 6;
                        break;
                    case "7":
                        cards[ind] = 5;
                        break;
                    case "8":
                        cards[ind] = 4;
                        break;
                    case "9":
                        cards[ind] = 3;
                        break;
                    case "10":
                        cards[ind] = 2;
                        break;
                    case "A":
                        cards[ind] = 1;
                        break;
                    case "J":
                        cards[ind] = 11;
                        break;
                    case "Q":
                        cards[ind] = 12;
                        break;
                    case "K":
                        cards[ind] = 13;
                        break;
                    default:
                        break;
                }

                if (ind < 3)
                {
                    playerOneCurrScore += cards[ind];
                }
                else
                {
                    playerTwoCurrScore += cards[ind];
                }
            }

            if (playerOneCurrScore > playerTwoCurrScore)
            {
                playerOneScore += playerOneCurrScore;
                playerOneGamesWon++;
            }
            else if (playerOneCurrScore < playerTwoCurrScore)
            {
                playerTwoScore += playerTwoCurrScore;
                playerTwoGamesWon++;
            }
        }

        if (!isXCardDrawn)
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", playerOneScore);
                Console.WriteLine("Games won: {0}",playerOneGamesWon);
            }
            else if (playerOneScore < playerTwoScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", playerTwoScore);
                Console.WriteLine("Games won: {0}",playerTwoGamesWon);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", playerOneScore);
            }
        }
    }
}

