using System.Collections.Generic;
using System.Linq;
using BussinesLogic;
using Repository;

namespace ApplicationEvents
{
    public class Application
    {
        private readonly IRepository _repository;

        public Application(IRepository repository)
        {
            this._repository = repository;
        }
        public IEnumerable<IEvent> Events()
        {
            return _repository.GetAll().Select(s => s.Trim()).Select(s => new Event { Name = s }).ToArray();
        }
    }
}
