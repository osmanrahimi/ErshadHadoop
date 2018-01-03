using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ershad.Hadoop.Map
{
    public class NamespaceMapper : MapperBase
    {
        //Override the map method.
        public override void Map(string inputLine, MapperContext context)
        {
            //Extract the namespace declarations in the Csharp files
            var reg = new Regex(@"(using)\s[A-za-z0-9_\.]*\;");
            var matches = reg.Matches(inputLine);

            foreach (Match match in matches)
            {
                //Just emit the namespaces.
                context.EmitKeyValue(match.Value, "1");
            }
        }
    }
}
