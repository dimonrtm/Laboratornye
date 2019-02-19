using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class MyWorkshop:Workshop,IMyInterface
    {
      public MyWorkshop():base() { }

      public MyWorkshop(string name,string chief,int numberOfWorkers) : base(name, chief, numberOfWorkers) { }

      public MyWorkshop(string name,string chief) : base(name, chief) { }

      public MyWorkshop(string name,int numberOfWorkers) : base(name, numberOfWorkers) { }

        public string this [int i]
        {
          get
            {
                if(i<ListOfTheProductRange.Count)
                {
                    return ListOfTheProductRange[i];
                }
                return "";
            }
          set
            {
                if(i<ListOfTheProductRange.Count)
                {
                    ListOfTheProductRange[i] = value;
                }
            }
        }

        public  void AddProduct(object product)
        {
            ListOfTheProductRange.Add((string)product);
        }

        public void RemoveProduct(object product)
        {
            ListOfTheProductRange.Remove((string)product);
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

        public int ProductIndex(object product)
        {
           int index= ListOfTheProductRange.IndexOf((string)product);
            return index;
        }

        private string ProductListToString()
        {
            string productString = "";
            foreach(string str in ListOfTheProductRange)
            {
                productString = productString + str + "\n";
            }
            return productString;
        }

        public override string ToString()
        {
            return String.Format("Название:\n{0}\nначальник:\n{1}\nколичество работников:\n{2}\nперечень номенклатуры выпускаемых изделий:\n{3}", Name, Chief, NumberOfWorkers, ProductListToString());
        }

    }
}
