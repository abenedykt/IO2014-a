using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserGeo.Model;

namespace ParserGeo.Services
{
    public interface IRepository
    {
        void Save(DataRecord record);
    }
}
