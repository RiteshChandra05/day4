using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractcls
{
    public abstract class Repository 
    {
        public abstract void print();
    }

    class Program : Repository
    {
        public override void print()
        {
            Console.WriteLine("print abstract");
        }
        static void Main(string[] args)
        {
            Repository R = new Program();
            R.print();
        }
    }
}
