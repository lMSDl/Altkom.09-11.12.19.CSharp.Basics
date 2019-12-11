using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.SOLID
{
    public abstract class Shape
    {
        public abstract int Area();
    }

    public class Square : Shape
    {
        public int A { get; set; }

        public override int Area()
        {
            return A * A;
        }
    }

    public class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }

        public override int Area()
        {
            return A * B;
        }
    }

    public class ShapeCalculator
    {
        public int Area(Shape shape)
        {
            return shape.Area();
        }
    }
}
