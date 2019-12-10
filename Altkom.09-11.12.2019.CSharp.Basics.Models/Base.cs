using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.Models
{
    public abstract class Base
    {
        private static int Counter = 0;

        public Base()
        {
            Id = ++Counter;
        }

        public int Id { get; }

        public abstract int GetSomeInt();
    }
}
