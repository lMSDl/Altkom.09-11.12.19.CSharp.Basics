using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Formatters
{
    class XmlFormatter
    {
        public string ToXml(object obj)
        {
            var json = new JsonFormatter().ToJson(obj);
            return JsonConvert.DeserializeXNode(json, obj.GetType().Name).ToString();
        }

        public string ToXml(IEnumerable<object> obj)
        {
            var json = new JsonFormatter().ToJson(obj);
            json = $"{{\"Entity\": {json} }}";
            return JsonConvert.DeserializeXNode(json, obj.GetType().Name).ToString();
        }
    }
}
