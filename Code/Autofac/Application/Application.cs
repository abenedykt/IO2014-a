using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IApplicationC;
using IRepositoryC;

namespace ApplicationC
{
    public class Application : IApplication
    {
        private readonly IRepository repository;

        public Application(IRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<IEvent> Events()
        {
            var values = repository.GetAll();

            return values.Select(n => new Event { Name = n });
        }
    }
}
