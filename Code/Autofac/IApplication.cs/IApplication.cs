﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IApplicationC
{
    public interface IApplication
    {
        IEnumerable<IEvent> Events();
    }
}
