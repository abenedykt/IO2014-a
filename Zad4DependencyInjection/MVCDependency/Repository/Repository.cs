using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Abstract;

namespace Repository
{
    public class Repository : IRepository
    {
        private IEnumerable<IEvent> Events;
 
        public Repository(IApplication Application)
        {
            
        }

        public IEnumerable<string> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
