using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IApplication
{
    public interface IApplicationC
    {
        IEnumerable<IEvent> Events();
    }
}
