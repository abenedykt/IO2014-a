using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IApplication;
using IRepository;

namespace Application
{
    public class Application: IApplication.IApplication
    {

        private readonly IRepository.IRepository Repo;
        private readonly IEnumerable<IEvent.IEvent> Events;

        public string Event()
        {
            throw new NotImplementedException();
        }

        public string App(IRepository.IRepository repo)
        {
            throw new NotImplementedException();
        }

        public Application(IRepository.IRepository repository, IEnumerable<IEvent.IEvent> Event)
        {
            this.Repo = repository;
            this.Events = Event;
        }


    }
}
