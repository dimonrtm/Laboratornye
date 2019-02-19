using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    interface IMyInterface
    {
         void AddProduct(int productId,string productName,int quantity);
        void RemoveProduct(Product product);
        int ProductIndex(Product product);
        void RemoveProduct(int index);
    }
}
