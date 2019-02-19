using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    [Serializable]
    public class MyWorkshop:Workshop,IMyInterface
    {
      public MyWorkshop():base() { }

      public MyWorkshop(string name,Employee chief,int numberOfWorkers) : base(name, chief, numberOfWorkers) { }

      public MyWorkshop(string name,Employee chief) : base(name, chief) { }

      public MyWorkshop(string name,int numberOfWorkers) : base(name, numberOfWorkers) { }

        public Product this [int i]
        {
          get
            {
                if(i<ListOfTheProductRange.Count)
                {
                    return ListOfTheProductRange[i];
                }
                return null;
            }
          set
            {
                if(i<ListOfTheProductRange.Count)
                {
                    ListOfTheProductRange[i] = value;
                }
            }
        }

        public  void AddProduct(int productId,string productName,int quantity)
        {
            ListOfTheProductRange.Add(new Product(productId,productName,quantity));
        }

        public void RemoveProduct(Product product)
        {
            ListOfTheProductRange.Remove(product);
        }

        public void RemoveProduct(int index)
        {
            if (index < ListOfTheProductRange.Count)
            {
                ListOfTheProductRange.RemoveAt(index);
            }
            else
            {
                throw new MyException("Выход за пределы списка");
            }
        }

        public int ProductIndex(Product product)
        {
           int index= ListOfTheProductRange.IndexOf(product);
            return index;
        }

        public string ProductListToString()
        {
            string productString = "";
            foreach(Product prod in ListOfTheProductRange)
            {
                productString = productString +prod.ToString() + "\n";
            }
            return productString;
        }

        public override string ToString()
        {
            return String.Format("Название:\n{0}\nначальник:\n{1}\nколичество работников:\n{2}\nперечень номенклатуры выпускаемых изделий:\n{3}", Name, Chief, NumberOfWorkers, ProductListToString());
        }

    }
}
