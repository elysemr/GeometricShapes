using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rec : Quad
    {
        public new void Print() //add "new" before void to tell the method that we want to hide the quad method to change to this one for rec
        {
            Console.WriteLine($"Perineter: {Perimeter()}, area: {Area()}");
        }
        /* public int Side1 { get; set; } 
         public int Side2 { get; set; } */
        //after inherit, we now have 2 side1s, if you want both, it will only use rec, if don't need, delete
        //same thing with the perimeter function, but don't have area in the quad class so can keep/need to keep  

     /*   public int Perimeter()
        {
            return (Side1 * 2) + (Side2 * 2);
        } */

//two ways to handle problem that comes up with trying to find area with data for 4 sides

        public int Area()
        {
            return Side1 * Side2;
        }
//constructor makes it so user can just enter 2 sides by assigning 2 values to 4 sides, now that you have one in quad
        public Rec(int SideA, int SideB) : base(SideA, SideB, SideA, SideB)
        {

        }
        //don't need this because have the base class to model off of
      /*  {
            Side1 = SideA;
            Side2 = SideB;
            Side3 = SideA;
            Side4 = SideB;
        } */
        //also need default constructor because wrote var with that originally
        public Rec() { }
    }
}
