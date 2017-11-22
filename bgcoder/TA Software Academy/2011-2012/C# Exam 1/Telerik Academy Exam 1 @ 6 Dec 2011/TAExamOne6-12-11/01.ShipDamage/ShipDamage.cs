using System;

class ShipDamage
{
    static void Main(string[] args)
    {
        int sXCord1 = -6; //int.Parse(Console.ReadLine());
        int sYCord1 = 6; //int.Parse(Console.ReadLine());

        int sXCord2 = -11; //int.Parse(Console.ReadLine());
        int sYCord2 = 3; //int.Parse(Console.ReadLine());

        int exchange = new int();
        if (sXCord1 > sXCord2)
        {
            exchange = sXCord1;
            sXCord1 = sXCord2;
            sXCord2 = exchange;
        }
        if (sYCord1 > sYCord2)
        {
            exchange = sYCord1;
            sYCord1 = sYCord2;
            sYCord2 = exchange;
        }

        int hor = 1; //int.Parse(Console.ReadLine());

        int catX1 = -9; //int.Parse(Console.ReadLine());
        int catY1 = -4; //int.Parse(Console.ReadLine());
        int catX2 = -11; //int.Parse(Console.ReadLine());
        int catY2 = -1; //int.Parse(Console.ReadLine());
        int catX3 = 2; //int.Parse(Console.ReadLine());
        int catY3 = 2; //int.Parse(Console.ReadLine());

        int hitX1 = catX1;
        int hitY1 = catY1 + ((hor - catY1) * 2);
        int hitX2 = catX2;
        int hitY2 = catY2 + ((hor - catY2) * 2);
        int hitX3 = catX3;
        int hitY3 = catY3 + ((hor - catY3) * 2);

        int damage = 0;

        //if
    }
}

