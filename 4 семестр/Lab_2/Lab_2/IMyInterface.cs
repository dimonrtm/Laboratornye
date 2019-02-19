using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    interface IMyInterface
    {
         void AddProduct(object product);
        void RemoveProduct(object product);
        int ProductIndex(object product);
        void RemoveProduct(int index);
    }
}
