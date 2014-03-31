using IApplicationCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositoryCL;

namespace ApplicationCL
{
    public class Application : IApplication
    {
        private readonly IRepository repo;

        public IEnumerable<IEvent> Events()
        {
            return repo.GetAll().Select(n => new Event() { Value = n.Trim()});
        }

        public Application(IRepository repository)
        {
            repo = repository;
        }
    }
}
