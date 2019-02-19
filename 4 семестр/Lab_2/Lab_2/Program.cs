using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWorkshop MW = new MyWorkshop("Сборочный цех", "Иванов Иван Иванович", 15);
            for(int i=0;i<10;i++)
            {
                MW.AddProduct("Изделие№" + (i + 1));
            }
            Console.WriteLine(MW);
            MW.RemoveProduct(9);
            Console.WriteLine(MW);
            MW[7] = "транзистор КТ-315 Г";
            Console.WriteLine(MW);
            Console.WriteLine(MW[4]);
            MW.RemoveProduct("Изделие№1");
            Console.WriteLine(MW);
            Console.WriteLine(MW.ProductIndex("транзистор КТ-315 Г"));
            try
            {
                MW.RemoveProduct(15);
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
