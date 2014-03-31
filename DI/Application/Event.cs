using IApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Event : IEvent
    {
        public string Name { get; set; }
    }
}
