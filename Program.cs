using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicdeligateprgm
{
    public delegate void delegatepgm(string st);
    class Program
    {
       
       public static void Main(string[] args)
        {
           delegatepgm D1= new delegatepgm(CallDelegate);
           D1("Hi");
        }
        public static void CallDelegate(string st)
       {
            Console.WriteLine(st);
       }
    }
}
