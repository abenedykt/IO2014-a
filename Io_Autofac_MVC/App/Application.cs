using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IApp;
using IRepo;

namespace App
{
    public class Application : IApplication
    {
        private IRepository repository;

        public Application(IRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<string> Trim()
        {
            return repository.GetAll();
        }

        public IEnumerable<IEvent> Events()
        {
            return repository.GetAll().Select(n => new Event(n));
        }
    }
}
