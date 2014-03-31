using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace Application
{
    public class Application : IApplication
    {
        private readonly IRepository Repository;

        public Application(IRepository Repository, IEnumerable<IEvent> Events)
        {
            this.Repository = Repository;
        }

        public IEnumerable<IEvent> Events()
        {
            throw new NotImplementedException();
        }

        public void App(IRepository Repository)
        {
            throw new NotImplementedException();
        }
    }
}
