using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositoryCL;

namespace IApplicationCL
{
    public interface IApplication
    {
        IEnumerable<IEvent> Events();
    }
}
