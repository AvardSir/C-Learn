using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxBid = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                int smth = Convert.ToInt32(Console.ReadLine());
                if (smth > maxBid) { Console.WriteLine("Продано: "+smth); }
            }
        }
    }
}
