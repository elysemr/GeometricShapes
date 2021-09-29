using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Square : Rec
    {
       /* public int Side1;

        public int Perimeter()
        {
            return Side1 * 4;
        } */

      /*  public int Area()
        {
            return Side1 * Side1;
        } */

        public Square(int Sides) : base(Sides, Sides) //can make this constructor call the constructor we wrote in rec by doing this <<
        {
           
        }
        public Square () { }
    }
}
