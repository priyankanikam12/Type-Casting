using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit
            byte b = 10;
            int i = b;
            long l = i;
            /*
            Explicit 1- (Not Data Loss)
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);
            Console.ReadLine();
             */
            /*
            Explicit 2- (Data Loss)
            double d = 50.25;
            int i = (int)d;
            Console.WriteLine(i);
            Console.ReadLine();
            */
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.ReadLine();
        }
    }
}
