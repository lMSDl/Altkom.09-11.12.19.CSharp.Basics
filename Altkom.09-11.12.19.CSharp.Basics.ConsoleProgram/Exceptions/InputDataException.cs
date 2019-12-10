using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Exceptions
{
    public class InputDataException : Exception
    {
        public string FieldName { get; }

        public InputDataException(string fieldName)
        {
            FieldName = fieldName;
        }
    }
}
