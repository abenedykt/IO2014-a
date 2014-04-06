using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.BusinessLogic;
using MVC.IRepository;

namespace MVC.ApplicationEvents
{
    public class Application : IApplication
    {
        private readonly IRepositoryY _repository;

        public Application(IRepositoryY repository)
        {
            this._repository = repository;
        }
        public IEnumerable<IEvent> Events()
        {
            return _repository.GetAll().Select(s => s.Trim()).Select(s => new Event { Name = s }).ToArray();
        }
    }
}
