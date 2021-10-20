using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            String[] stringArray = startString.Split();
            int a = 0;
            string str ="";
            foreach (string s in stringArray)
            {
                if (a < s.Length)
                { a = s.Length;
                    str = s;
                } 
                                        
            }
            Console.Write(str);
            Console.ReadKey();
        }
    }
}
