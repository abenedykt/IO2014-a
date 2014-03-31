using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public interface IApplication
    {
        IEnumerable<IEvent> Events();
        void App(IRepository Repository);
    }

    public interface IRepository
    {
        IEnumerable<string> GetAll();
    }

    public interface IEvent
    {
        
    }
}
