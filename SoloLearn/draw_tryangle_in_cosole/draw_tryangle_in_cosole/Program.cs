using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draw_tryangle_in_cosole
{
    internal class Program
    {
        static void half_tryangle_upper(int width)
        {

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void half_tryangle_down(int width)
        {

            for (int i = width; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void tryangle(int width)
        {
            half_tryangle_upper(width);
            half_tryangle_down(width);

        }


        static void half_re_tryangle_upper(int width)
        {

            for (int i = 0; i < width; i++)
            {
                int temp = width - i;
                for (int j = 0; j < temp; j++)
                {   
                    Console.Write(' ');
                }
                for (int j = 0; j<i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void half_re_tryangle_down(int width)
        {

            for (int i = 0; i < width; i++)
            {
                int temp = width-i  ;
                for (int j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < temp; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void re_tryangle(int width)
        {
            half_re_tryangle_upper(width);
            half_re_tryangle_down(width);

        }
        static void pattern_tryangle(int count)
        {
            for (int i = 0; i < count; i++) { 
                re_tryangle(count);
                tryangle(count);
            }
        }
        static void Main(string[] args)
        {
            //int width = 600;
            while (true)
            {
                Console.Write("count of Tryangle(you can 600 and its be fun visual bugs):\t"); int width = Convert.ToInt32(Console.ReadLine());

                pattern_tryangle(width);
            }
            

        }
    }
}
