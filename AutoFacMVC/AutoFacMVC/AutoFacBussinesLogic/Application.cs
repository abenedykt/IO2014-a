using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFacApplicationElements;
using AUtoFacRepository;

namespace AutoFacBussinesLogic
{
    public class Application : IApplicationElements
    {
        private readonly IRepository _repo;
        public Application(IRepository repo)
        {
            this._repo = repo;
        }

     
        public IEnumerable<IEvent> Events()
        {
            return _repo.GetAll().Select(s => s.Trim()).Select(s => new Event { Name = s }).ToArray();
        }

        public void Events()
        {
            throw new NotImplementedException();
        }
    }
}
