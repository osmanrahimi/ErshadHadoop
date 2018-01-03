using Ershad.Hadoop.Map;
using Ershad.Hadoop.Reduce;
using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ershad.Hadoop.JobSchedule
{
    public class NamespaceCounterJob : HadoopJob<NamespaceMapper, NamespaceReducer>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            var config = new HadoopJobConfiguration();
            config.InputPath = "input/CodeFiles";
            config.OutputFolder = "output/CodeFiles";
            return config;
        }
    }
}
