using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_4
{
    [Serializable]
    public abstract class Workshop
    {
        private string name;
        private Employee chief;
        private int numberOfWorkers;
        private List<Product> listOfTheProductRange=new List<Product>();

        public Workshop() {
            name = "";
            chief = null;
            numberOfWorkers = 0;
        }

        public Workshop(string name,Employee chief,int numberOfWorkers)
        {
            this.name = name;
            this.chief = chief;
            this.numberOfWorkers = numberOfWorkers;
        }

        public Workshop(string name,Employee chief) : this(name, chief, 0) { }

        public Workshop(string name,int numberOfWorkers) : this(name, null, numberOfWorkers) { }

        
        public string Name
        {
            get
            {
                return name;
                    }
            set
            {
                name = value;
            }

        }
       
        public Employee Chief
        {
            get
            {
                return chief;
            }
            set
            {
                chief = value;
            }
        }
      
        public int NumberOfWorkers
        {
            get
            {
                return numberOfWorkers;
            }   
            set
            {
                numberOfWorkers = value;
            }
        }
        [XmlElement]
        public List<Product> ListOfTheProductRange
        {
            get
            {
                return listOfTheProductRange;
            }
            set
            {
                listOfTheProductRange = value;
            }
        }
    }
}
