using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ershad.Hadoop.TaskScheduler
{
    public interface IStorage
    {
        void Store(int batchId, object value, int level);
        IEnumerable<IEnumerable<object>> GetBatchesFor(int level);
    }
}
