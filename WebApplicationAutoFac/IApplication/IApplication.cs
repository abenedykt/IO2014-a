﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IApplication
{
    public interface IApplication
    {
        string Event();
        string App(IRepository.IRepository repo);
    }
    

}