using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vector v = new Vector(7, 14);
            Vector vv = new Vector(69,4);

            Vector r = new Vector(0,0);

            r = v + vv;

            Console.WriteLine("{0}",r.ToString());
            Console.ReadLine();
        }
    }
}
