using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Formatters
{
    public class CsvFormatter
    {
        public string ToCsv<T>(IEnumerable<T> obj)
        {
            return CsvSerializer.SerializeToCsv(obj);
        }

        public T FromCsv<T>(string csv)
        {
            return CsvSerializer.DeserializeFromString<T>(csv);
        }
    }
}
