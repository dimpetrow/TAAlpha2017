using System;

namespace _06.TriangleSurfByTwoSidesNAngle
{
    class Program
    {
        static double TriangleSurface(double x, double y, double angle)
        {
            double sin = Math.Sin(angle);
            double surface = Math.Round((x * y * sin) / 2, 2);

            return surface;
        }


        static void Main(string[] args)
        {
            double a = 20;//int.Parse(Console.ReadLine());
            double b = 7;//int.Parse(Console.ReadLine());
            double angle = Math.PI / 6;//int.Parse(Console.ReadLine());

            Console.WriteLine(TriangleSurface(a, b, angle));
        }
    }
}
