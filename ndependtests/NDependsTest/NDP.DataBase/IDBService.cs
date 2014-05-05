using System.Collections.Generic;

namespace NDP.Abstract
{
    public interface IDbService
    {
        void FindById(int id);
        void FindByName(string name);
        void AddObjectToDb(object obj);
        void UpdateObjectToDb(object obj);
        void RemoveObjectFromDb(object obj);
        void SelectObjectFromDb(object obj);
        void SelectManyObjects(IEnumerable<object> objList);

    }
}
