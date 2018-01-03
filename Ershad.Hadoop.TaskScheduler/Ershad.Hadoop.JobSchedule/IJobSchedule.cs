using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ershad.Hadoop.JobSchedule
{
    public interface IJobSchedule
    {
        T Map<T>(Action<T> map, byte[] data);
    }
}
