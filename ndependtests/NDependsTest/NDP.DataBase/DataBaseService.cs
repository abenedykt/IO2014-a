using NDP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDP.Models;

namespace NDP.DataBase
{
    public class DataBaseService : IDbService
    {
        public List<string> lstProd = new List<string>();
        public void FindById(int id)
        {
            lstProd.Select(n => n.Name.Where(n => n.Id == id)).First();
        }

        public void FindByName(string name)
        {
            lstProd.Select(n => n.Name.Where(n => n.Name == name)).FirstOrDefoult();
        }

        public void AddObjectToDb(object obj)
        {
            lstProd.Add(obj);
        }

        public void UpdateObjectToDb(object obj)
        {
            throw new NotImplementedException();
        }

        public void RemoveObjectFromDb(object obj)
        {
            throw new NotImplementedException();
        }

        public void SelectObjectFromDb(object obj)
        {
            throw new NotImplementedException();
        }

        public void SelectManyObjects(IEnumerable<object> objList)
        {
            throw new NotImplementedException();
        }

    }
}
