using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.SOLID
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    public class Airplain : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am flying!");
        }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("I am driving!");
        }
    }
}
