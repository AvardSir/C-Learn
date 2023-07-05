using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace massivs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[10];
            array[0] = 1000;
            for (int i = 1; i < array.Length+1; i++) {//заполнение
                array[i-1] = i*2;
            }
            
            for (int i = 0; i < array.Length; i++)
            {//вывод масива
                Console.WriteLine(array[i]);
            }
            
            
        }
    }
}
