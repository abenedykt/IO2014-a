using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IApplicationCL;

namespace ApplicationCL
{
    public class Event : IEvent
    {
        public string Value { get; set; }
    }
}
