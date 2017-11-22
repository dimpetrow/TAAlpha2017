using System;

class Poker
{
    static void Main(string[] args)
    {
        string[] cardsStr = { "4","4","4","4","K" };//new string[5];
        int[] cards = new int[5];
        for (int i = 0; i < 5; i++)
        {
            //cardsStr[i] = Console.ReadLine();

            if (!( (cardsStr[i][0] >= 50) && (cardsStr[i][0] <= 57) ) || (cardsStr[i] == "10") )
            {
                switch (cardsStr[i])
                {
                    case "J":
                        cards[i] = 11;
                        break;
                    case "Q":
                        cards[i] = 12;
                        break;
                    case "K":
                        cards[i] = 13;
                        break;
                    case "A":
                        cards[i] = 1;
                        break;
                    case "10":
                        cards[i] = 10;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                cards[i] = int.Parse(cardsStr[i]);
            }
        }

        //

        if ((cards[0] == cards[1]) && (cards[1] == cards[2]) && (cards[2] == cards[3]) && (cards[3] == cards[4]))
        {
            Console.WriteLine("Impossible");
        }
        else if (true)
        {

        }
    }
}
