using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Square()
            {
                Side1 = 5
            };
            Console.WriteLine($"Perimeter is {s1.Perimeter()}");
            Console.WriteLine($"Area is {s1.Area()}");

            var r1 = new Rec()
            {
                Side1 = 3,
                Side2 = 5
            };
            Console.WriteLine($"Perimeter is {r1.Perimeter()}");
            Console.WriteLine($"Area is {r1.Area()}");

            var q1 = new Quad()
            {
                Side1 = 3,
                Side2 = 4,
                Side3 = 5,
                Side4 = 6
            }; //this syntax is one of the rare instances when a } will be followed by a ;
            //to test code, we need to know what the right answer is before we run it
            Console.WriteLine($"Perimeter is {q1.Perimeter()}");
        }
    }
}
