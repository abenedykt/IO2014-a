using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLogic;


namespace ApplicationEvents
{
    public class Event : IEvent
    {
        public string Name { get; set; }
    }
}
