using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
           var s1 = new Square()
            {
                Side1 = 5,
                Side2 = 5,
                Side3 = 5,
                Side4 = 5
            };
            s1.Print();
            //now that have a method in quad for printing the perim, can just do this instead of cw lines below
            //Console.WriteLine($"Square perimeter is {s1.Perimeter()}");
            //Console.WriteLine($"Square area is {s1.Area()}");

            var s2 = new Square(6);
            s2.Print();
            //Console.WriteLine($"Square perimeter is {s2.Perimeter()}");
            //Console.WriteLine($"Square area is {s2.Area()}");

            //with inherit, can add more info (two more sides with the same measurements) to make calcs work since inherited class has 4 sides

            var r1 = new Rec()
            {
                Side1 = 3,
                Side2 = 5,
                Side3 = 3,
                Side4 = 5
            };
            r1.Print();
            //Console.WriteLine($"Rectangle perimeter is {r1.Perimeter()}");
            //Console.WriteLine($"Rectangle area is {r1.Area()}");

            //if want to allow user to only have to enter 2 sides, create constructor in rec class
            var r2 = new Rec(3,7); //less typing is less error prone
            r2.Print();
            //Console.WriteLine($"Rectangle perimeter is {r2.Perimeter()}");
            //Console.WriteLine($"Rectangle area is {r2.Area()}");

            var q1 = new Quad()
            {
                Side1 = 3,
                Side2 = 4,
                Side3 = 5,
                Side4 = 6
            }; //this syntax is one of the rare instances when a } will be followed by a ;
            //to test code, we need to know what the right answer is before we run it
            //Console.WriteLine($"Quad perimeter is {q1.Perimeter()}");
            q1.Print();

            //now that have constructor in quad, can just use this instead of all the work above
            var q2 = new Quad(3, 4, 5, 6);
            q2.Print();
            //Console.WriteLine($"Quad perimeter is {q1.Perimeter()}");
        }
    }
}
