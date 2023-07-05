using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace logical_operand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*if (1+22==3 && 3-2==1 || 30==25+5){ Console.WriteLine("AND\t :\t1+2=3"); }

            if (1+3==40 || 2 + 3 == 5) { Console.WriteLine("OR\t :\t2+3=5"); }

            if (1 + 30 != 4) { Console.WriteLine("NOT\t :\t1+2!=4"); }





            Console.Write("what num:?\t"); int input_num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("")
            Console.WriteLine(input_num);*/
            int attendance = Convert.ToInt32(Console.ReadLine());
            int avgScore = Convert.ToInt32(Console.ReadLine());
            /*if (attendance >= 95 && avgScore >= 80) { Console.WriteLine("Accepted"); }
            else { Console.WriteLine("Denied"); }
            
            
*/
            string msg = (attendance >= 95 && avgScore >= 80) ? "Accepted" : "Denied";
            Console.WriteLine(msg) ;

            /*string msg2 = (attendance >= 95 && avgScore >= 80) ? "Accepted" : "Denied");*/
            Console.WriteLine((attendance >= 95 && avgScore >= 80) ? "Accepted" : "Denied");
            /*string s=(3>2)? "GG" : ":(((";*/
            Console.WriteLine((3 > 2) ? "GG" : ":(((");
        }
    }
}
