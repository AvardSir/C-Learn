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
        {/*
            Console.WriteLine("input first:\t");
            string a = Console.ReadLine();
            int a_int = Convert.ToInt32(a);

            Console.WriteLine("input second:\t");
            string b = Console.ReadLine();
            int b_int = Convert.ToInt32(b);

            Console.WriteLine("output is:\t"+ (a_int + b_int));
            //Console.WriteLine();
            Console.Read();*/

            Console.WriteLine("Введи первое число котороре суммируеца:\t");//тож самое что выше ток с переводом на Ru
            string a = Console.ReadLine();
            int a_int = Convert.ToInt32(a);

            Console.WriteLine("Введи второе число котороре суммируеца:\t");
            string b = Console.ReadLine();
            int b_int = Convert.ToInt32(b);

            Console.WriteLine("В итоге сумма это:\t" + (a_int + b_int));
            //Console.WriteLine();
            Console.Read();


        }
    }
}
