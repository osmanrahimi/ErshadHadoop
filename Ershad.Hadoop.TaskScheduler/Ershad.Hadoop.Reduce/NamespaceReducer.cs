using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ershad.Hadoop.Reduce
{
    public class NamespaceReducer : ReducerCombinerBase
    {
        //Accepts each key and count the occurrances
        public override void Reduce(string key, IEnumerable<string> values,
            ReducerCombinerContext context)
        {
            //Write back  
            context.EmitKeyValue(key, values.Count().ToString());
        }
    }
}
