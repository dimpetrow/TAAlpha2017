using System;

class MissCat2011
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] juryVotes = new int[n];
        for (int i = 0; i < n; i++)
        {
            juryVotes[i] = int.Parse(Console.ReadLine());
        }
        int biggestNumberOfVotes = 0;
        int winnerVote = 0;
        int winnerCatNum = new int();

        for (int cat = 1; cat < 10; cat++)
        {
            for (int vote = 0; vote < n; vote++)
            {
                if (juryVotes[vote] == cat)
                {
                    biggestNumberOfVotes++;
                }

                if (biggestNumberOfVotes > winnerVote)
                {
                    winnerVote = biggestNumberOfVotes;
                    winnerCatNum = cat;
                }
            }
            biggestNumberOfVotes = 0;
        }
        Console.WriteLine(winnerCatNum);
    }
}

