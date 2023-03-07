using System;

namespace Triangle
{
    class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinate x of dot A:");
            double ax = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A:");
            double ay = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B:");
            double bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B:");
            double by = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C:");
            double cx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C:");
            double cy = double.Parse(Console.ReadLine());

            // Length
            double ab = Distance(ax, ay, bx, by);
            double bc = Distance(bx, by, cx, cy);
            double ac = Distance(ax, ay, cx, cy);


            Console.WriteLine($"Length of AB is: {ab}");
            Console.WriteLine($"Length of BC is: {bc}");
            Console.WriteLine($"Length of AC is: {ac}");

            // Equilateral
            bool Equal = (ab == bc) && (bc == ac);
            if (Equal)
            {
                Console.WriteLine("Triangle is 'Equilateral'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Equilateral'");
            }

            // Isosceles
            bool Isos = (ab == bc) || (bc == ac) || (ab == ac);
            if (Isos)
            {
                Console.WriteLine("Triangle is 'Isosceles'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Isosceles'");
            }

            // Right
            double delta = 0.0001;
            bool Right = Math.Abs(bc * bc - (ab * ab + ac * ac)) <= delta;
            if (Right)
            {
                Console.WriteLine("Triangle is 'Right'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Right'");
            }

            // Perimeter
            double perimeter = ab + bc + ac;
            Console.WriteLine($"Perimeter: {perimeter}");


            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
            for (int i = 0; i <= (int)perimeter; i += 2)
            {
                Console.Write(i + " ");
            }
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
