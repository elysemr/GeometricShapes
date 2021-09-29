using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Quad
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }

        public int Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }

        public Quad(int Side1, int Side2, int Side3, int Side4)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
            this.Side3 = Side3;
            this.Side4 = Side4;
        }
        public Quad() { }


    }
}
