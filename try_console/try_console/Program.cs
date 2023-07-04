using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input first:\t");
            string a = Console.ReadLine();
            int a_int = Convert.ToInt32(a);

            Console.WriteLine("input second:\t");
            string b = Console.ReadLine();
            int b_int = Convert.ToInt32(b);

            Console.WriteLine(a_int + b_int);
        }
    }
}
