using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<int> Swap(List<int>intlist)
        {
            for(int o=0; o < Math.Pow(intlist.Count, 2); o++)
            {
                for(int i = 0; i < intlist.Count; i++)
                {
                    if( i < intlist.Count - 1 && intlist[i] > intlist[i + 1])
                    {
                        int int_temp = intlist[i];
                        intlist[i] = intlist[i + 1];
                        intlist[i + 1] = int_temp;
                    }
                }
            }
            return intlist;
        }

        static void Main(string[] args)
        {
             List<int> sortlist = new List<int>() { 5, 7, 3, 6, 2, 9, 6, 5, 4, 1, 8, 9 };
           
            sortlist = Swap(sortlist);

            for (int i = 0; i < sortlist.Count; i++)
            {
                Console.Write(sortlist[i]);
            }
            Console.ReadLine();
        }
    }
}
