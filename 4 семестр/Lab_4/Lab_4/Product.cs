using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_4
{
    [Serializable]
    public class Product
    {
        private int productId;
        private string productName;
        private int quantity;

        public Product()
        {

        }
        public Product(int productId,string productName,int quantity)
        {
            this.productId = productId;
            this.productName = productName;
            this.quantity = quantity;
        }

        public string Name
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public int Id
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Номер продукта {0}\nНазвание продукта {1}\n Количество продукта {2}", productId, productName, quantity);
        }
    }
}
