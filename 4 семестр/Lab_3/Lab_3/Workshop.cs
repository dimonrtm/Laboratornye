using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class Workshop
    {
        private string name;
        private string chief;
        private int numberOfWorkers;
        private List<string> listOfTheProductRange=new List<string>();

        public Workshop() { }

        public Workshop(string name,string chief,int numberOfWorkers)
        {
            this.name = name;
            this.chief = chief;
            this.numberOfWorkers = numberOfWorkers;
        }

        public Workshop(string name,string chief) : this(name, chief, 0) { }

        public Workshop(string name,int numberOfWorkers) : this(name, "", numberOfWorkers) { }

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

        public string Chief
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
        
        public List<string> ListOfTheProductRange
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
