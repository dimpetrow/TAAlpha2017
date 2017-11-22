using System;

class FighterAttack
{
    static void Main(string[] args)
    {
        int pX1 =  6; //int.Parse(Console.ReadLine());
        int pY1 =  5; //int.Parse(Console.ReadLine());

        int pX2 =  2; //int.Parse(Console.ReadLine());
        int pY2 =  3; //int.Parse(Console.ReadLine());

        int fX =  0; //int.Parse(Console.ReadLine());
        int fY =  1; //int.Parse(Console.ReadLine());
        int d = -3; //int.Parse(Console.ReadLine());

        int biggerX = pX1;
        int smallerX = pX2;
        int biggerY = pY1;
        int smallerY = pY2;
        if (pX1 < pX2)
        {
            biggerX = pX2;
            smallerX = pX1;
        }
        if (pY1 < pY2)
        {
            biggerY = pY2;
            smallerY = pY1;
        }

        int hitX = fX + d;
        int hitY = fY;

        int hitUpX = hitX;
        int hitUpY = hitY + 1;
        int hitDownX = hitX;
        int hitDownY = hitY - 1;
        int hitFrontX = hitX + 1;
        int hitFrontY = hitY;

        int damage = 0;

        if (( (hitX >= smallerX) && (hitX <= biggerX) ) && ( (hitY >= smallerY) && (hitY <= biggerY) ))
        {
            damage += 100;
        }

        if (((hitUpX >= smallerX) && (hitUpX <= biggerX)) && ((hitUpY >= smallerY) && (hitUpY <= biggerY)))
        {
            damage += 50;
        }

        if (((hitDownX >= smallerX) && (hitDownX <= biggerX)) && ((hitDownY >= smallerY) && (hitDownY <= biggerY)))
        {
            damage += 50;
        }

        if (((hitFrontX >= smallerX) && (hitFrontX <= biggerX)) && ((hitFrontY >= smallerY) && (hitFrontY <= biggerY)))
        {
            damage += 75;
        }

        Console.WriteLine(damage + "%");
    }
}

