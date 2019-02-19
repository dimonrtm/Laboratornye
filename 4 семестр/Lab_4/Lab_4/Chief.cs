using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_4
{
[Serializable]
    public class Employee
    {
        private string fullName;
        private string position;
        private int salary;
        public Employee()
        {

        }
        public Employee(string fullName,string position, int salary)
        {
            this.fullName = fullName;
            this.position = position;
            this.salary = salary;
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }


        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public override string ToString()
        {
            return String.Format("ФИО {0}\nДолжность {1}\n Зарплата {2}", fullName, position, salary);
        }
    }
}
