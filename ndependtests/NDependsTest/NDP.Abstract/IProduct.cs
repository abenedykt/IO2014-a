using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP.Abstract
{
    public interface IProduct
    {
        void AddProduct(object obj);
        void ShowProducts(object obj);
        void RemoveProducts(object obj);
        double CalculateProductTax(object obj);
        uint CalculateProductQuantityInStorage(object obj);
    }
}
