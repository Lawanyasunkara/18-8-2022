using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangEnhancement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("enter the value for n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value for n2");
            n2= Convert.ToInt32(Console.ReadLine());
            if(n1>n2)
            {
                Console.WriteLine("n1 is greater");
            }
            else
            {
                Console.WriteLine("n2 is greater");
            }
            Console.ReadLine();        }
    }
}
