using IApplication;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ApplicationC : IApplicationC
    {
        private readonly IRepositoryC repository;

        public ApplicationC(IRepositoryC repository)
        {
            this.repository = repository;
        }

        public IEnumerable<IEvent> Events()
        {
            return repository.GetAll().Select(s => s.Trim()).Select(s => new Event { Name = s }).ToArray();

        }
    }
}
