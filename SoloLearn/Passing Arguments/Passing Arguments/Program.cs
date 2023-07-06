using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Passing_Arguments
{
    internal class Program
    {
        static void sum(ref int a , int b)
        {
            a=a+b;
        }

        static void change_colour(ref string a)
        {
            a = "Red";
        }
        static void change_motor(ref string a)
        {
            a = "Motor: Lexus";
        }
        static void Main(string[] args)
        {
            /*int a = 1;int b = 2;int c = 3;
            sum(ref a,  b);
            Console.WriteLine(a);*/

            /*var My_car_motor = "Men";
            var My_car_color = "Blue";
            change_colour(ref My_car_color);
            change_motor(ref My_car_motor);

            Console.WriteLine(My_car_motor);
            Console.WriteLine(My_car_color);

*/
            /*int salaryBudget = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before the increase: " + salaryBudget);

            //complete the method call
            Increase(ref salaryBudget, percent);

            Console.WriteLine("After the increase: " + salaryBudget);*/

            string My_mood = "sad:(((((";
            be_happy(out My_mood);

            int aaa=32;
        }
        //complete the method
        static void Increase(ref int salaryBudget, int percent)
        {
            salaryBudget= (salaryBudget*(percent+100))/100;
        }
        static void be_happy(out string a) { a = "HappyHappyHappy :))"; }
    }
}
