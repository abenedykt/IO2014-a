using System.Collections;
using System.Collections.Generic;

namespace MVC.BusinessLogic
{
    public interface IApplication
    {
        IEnumerable<IEvent> Events();
    }
}
