using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._2019.CSharp.Basics.Db.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public User User {get; set;}
    }
}
