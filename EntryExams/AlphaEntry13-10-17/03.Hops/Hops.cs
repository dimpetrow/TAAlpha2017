using System;

class Hops
{
    static void Main(string[] args)
    {
        string carrotsInp = Console.ReadLine();
        string[] carrots = carrotsInp.Split(' ');
        carrots = carrotsInp.Split(',');
        //Get carrots field

        int m = int.Parse(Console.ReadLine());
        //Get hop sequence count

        int maxCarrotsEaten = int.MinValue;

        for (int seqs = 0; seqs < m; seqs++)
        {
            int currentCarrotsEaten = 0;
            string seq = Console.ReadLine();

            string[] hops = seq.Split(' ');
            hops = seq.Split(',');
            //Get a hop sequence


            int[] carrotsEaten = new int[carrots.Length];
            carrotsEaten[0] = 1;
            currentCarrotsEaten += int.Parse(carrots[0]);

            for (int i = 0, currentCarrot = 0; ;)
            {
                int hop = int.Parse(hops[i]);

                if (( ((currentCarrot + hop) > (carrots.Length - 1)) || ((currentCarrot + hop) < 0) ) || (carrotsEaten[currentCarrot + hop] == 1))
                {
                    break;
                }
                //Check if the rabit hops to empty of carrots place or outside carrots field

                carrotsEaten[currentCarrot + hop] = 1;

                currentCarrotsEaten += int.Parse(carrots[currentCarrot + hop]);
                currentCarrot += hop;

                if (i == (hops.Length - 1))
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            //Hop and eat carrots

            if (currentCarrotsEaten > maxCarrotsEaten)
            {
                maxCarrotsEaten = currentCarrotsEaten;
            }
        }

        Console.WriteLine(maxCarrotsEaten);
    }
}
