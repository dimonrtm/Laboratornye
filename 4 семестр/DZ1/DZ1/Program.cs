using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    
    class Program
    {
       static int ComputationOfCentury(int year)
        {
            int century;
            if(year%100==0)
            {
                century = year / 100;
            }
            else
            {
                century = year / 100 + 1;
            }
            return century;
        }
        static void Main(string[] args)
        {
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                int century = ComputationOfCentury(year);
                Console.WriteLine(century);
                Console.ReadKey();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
        }
    }
}
