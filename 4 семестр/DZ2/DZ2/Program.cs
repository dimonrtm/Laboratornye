using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static int WorkWithStrings(string str)
        {
            int sumOpenParenthesis = 0;
            int sumCloseParenthesis = 0;
            int indexFirstCloseParenthesis=0;
            int indexCloseParenthesis = 0;
            int indexOpenParnthesis = 0;
            for (int i= 0;i< str.Length;i++)
            {
                if(str[i]=='(')
                {
                    sumOpenParenthesis++;
                    indexOpenParnthesis = i;
                    if(indexOpenParnthesis>indexCloseParenthesis&&indexCloseParenthesis!=0)
                    {
                        return indexCloseParenthesis;
                    }
                }
                if(str[i]==')')
                {
                    ++sumCloseParenthesis;
                    indexCloseParenthesis = i;
                    if(indexCloseParenthesis==0)
                    {
                        return -1;
                    }

                    if(sumCloseParenthesis==sumOpenParenthesis+1)
                    {
                        indexFirstCloseParenthesis = i;
                    }
                }
            }
                if (sumOpenParenthesis == sumCloseParenthesis)
                {
                    return 0;
                }
                if(sumOpenParenthesis<sumCloseParenthesis)
                {
                    return indexFirstCloseParenthesis;
                }
                if(sumOpenParenthesis>sumCloseParenthesis)
                {
                    return -1;
                }
            return -1;

        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(WorkWithStrings(str));
            Console.ReadKey();
        }
    }
}
