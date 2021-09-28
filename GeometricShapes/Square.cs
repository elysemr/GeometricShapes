using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Square
    {
        public int Side1;

        public int Perimeter()
        {
            return Side1 * 4;
        }

        public int Area()
        {
            return Side1 * Side1;
        }
    }
}
