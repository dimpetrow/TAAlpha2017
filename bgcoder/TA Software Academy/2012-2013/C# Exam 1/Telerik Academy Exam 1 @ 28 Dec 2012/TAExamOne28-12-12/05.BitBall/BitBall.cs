using System;

class BitBall
{
    static void Main(string[] args)
    {
        int[] players = { 255, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 0, 0, 0, 0, 255 };//new int[16];
        //for (int i = 0; i < 16; i++)
        //{
        //    players[i] = int.Parse(Console.ReadLine());
        //}
        string[][] topTeam = new string[8][];
        string[][] downTeam = new string[8][];
        string[][] directions = new string[8][];
        for (int i = 0; i < 8; i++)
        {
            string topPlayers = Convert.ToString(players[i], 2);
            topPlayers = topPlayers.PadLeft(8, '0');
            string downPlayers = Convert.ToString(players[i + 8], 2);
            downPlayers = downPlayers.PadLeft(8, '0');

            topTeam[i] = new string[8];
            downTeam[i] = new string[8];

            for (int k = 0; k < 8; k++)
            {
                if (topPlayers[k] == '1')
                {
                    topTeam[i][k] = "d";
                }
                if (downPlayers[k] == '1')
                {
                    downTeam[i][k] = "u";
                }
            }
        }
        for (int i = 0; i < 8; i++)
        {
            for (int k = 0; k < 8; k++)
            {
                if ((topTeam[i][k] != null) ^ (downTeam[i][k] != null))
                {

                }
                else
                {
                    topTeam[i][k] = null;
                    downTeam[i][k] = null;
                }
            }
        } // Directions
        for (int i = 0; i < 8; i++)
        {
            directions[i] = new string[8];
            for (int k = 0; k < 8; k++)
            {
                if (topTeam[i][k] == "d")
                {
                    directions[i][k] = "d";
                }
                else if (downTeam[i][k] == "u")
                {
                    directions[i][k] = "u";
                }
            }
        }

        
        //for (int i = 0; i < 8; i++)
        //{
        //    foreach (var item in directions[i])
        //    {
        //        if (item == null)
        //        {
        //            Console.Write("+");
        //        }
        //        Console.Write(item);
        //    }
        //    Console.WriteLine();
        //}

        
        int topTeamScore = 0;
        int downTeamScore = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int k = 0; k < 8; k++)
            {
                if (directions[i][k] != null)
                {
                    if (directions[i][k] == "d")
                    {
                        for (int start = i + 1; start < 8; start++)
                        {
                            if (directions[start][k] != null)
                            {
                                break;
                            }

                            if (start == 7)
                            {
                                topTeamScore++;
                            }
                        }
                    }
                    else if (directions[i][k] == "u")
                    {
                        for (int start = i - 1; start >= 0; start--)
                        {
                            if (directions[start][k] != null)
                            {
                                break;
                            }

                            if (start == 0)
                            {
                                downTeamScore++;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(topTeamScore + ":" + downTeamScore);
    }
}

