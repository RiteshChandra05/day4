using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfce
{
    interface Iprint
    {
        void print1();
    }

    interface Ifax : Iprint
    {
        void print2();
    }
    public class usage : Ifax
    {
        public void print2()
        {
            Console.WriteLine("2 copy");
        }
        public void print1()
        {
            Console.WriteLine("1 copy");
        }

    }
    class Program
    {

    public static void Main(string[] args)
        {
            usage user = new usage();
            user.print1();
            user.print2();

        }
    }
}
