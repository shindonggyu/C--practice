using System;

namespace Solution6To8
{
    class Program
    {
        static void Main(string[] args)
        {
            int inch;
            double cm;
            Console.WriteLine("Please input inch in integer");
            inch = int.Parse(Console.ReadLine());
            cm = inch * 2.54;
            Console.WriteLine(inch + "inch is "+ cm + "cm");


            int kg;
            double pound;
            Console.WriteLine("Please input kg in integer");
            kg = int.Parse(Console.ReadLine());
            pound = kg * 2.20462262;
            Console.WriteLine(kg + "kg is " + pound + "pounds");


            int radius;
            double area;
            double circleLine;

            Console.WriteLine("Please input radius in integer");
            radius = int.Parse(Console.ReadLine());
            area = radius * radius * 3.14;
            circleLine = radius * 2 * 3.14;
            Console.WriteLine("Area of circle is "+ area + ",");
            Console.WriteLine("line of circle is " + circleLine);
        }
    }
}
