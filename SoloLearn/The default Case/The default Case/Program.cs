using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1) { Console.WriteLine("Easy"); }
            else if (num == 2) { Console.WriteLine("Medium");}
            else if(num == 3) { Console.WriteLine("Hard"); }
            else { Console.WriteLine("Invalid option"); }
            /*
            1 - Easy
            2 - Medium
            3 - Hard
            other - "Invalid option"
            */

            //your code goes here

        }
    }
}