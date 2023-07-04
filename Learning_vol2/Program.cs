using System;
using System.ComponentModel;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Learning_vol2
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!!!");
            Console.WriteLine("hello dad!!!");
            Console.WriteLine("hello mom!!!");
            Console.WriteLine("hello goverment!!!");
        }
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello haha!!!"); /*ну что получается юсинг это как импорт  в питоне*/
            Console.WriteLine("hello hehe!!!");
            { Console.WriteLine("Out_bound"); }
            int a = 12;
            int b = 12;
            int c = 12;
            string s = a.ToString();

            //to int
            { b = int.Parse(s); Console.WriteLine(b); }

            //to decimal
            {
                decimal f = 10;
                s = "123";
                f = Convert.ToDecimal(s);
                Console.WriteLine(f);
            }


            Console.WriteLine(b + 10);
            //Console.WriteLine(a + b + c);   
            Console.WriteLine(s + 'g');

            int a_A; System.Console.WriteLine("hello haha!!!"); /*ну что получается юсинг это как импорт  в питоне*/
            Console.WriteLine("hello hehe!!!");
            { Console.WriteLine("Out_bound"); }
            bool im_cool = true;
            bool homework_is_boring = true;
            bool war_is_peace = false;
            if (im_cool){ Console.WriteLine("im cool");if (homework_is_boring) {Console.WriteLine("homework boring");if (war_is_peace) { Console.WriteLine("war is peac"); }; (else) { Console.WriteLine("war is NOT peac"); } } }
        }
    }
}
