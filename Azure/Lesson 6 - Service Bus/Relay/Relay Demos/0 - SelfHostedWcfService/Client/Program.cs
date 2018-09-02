using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWCF.Service1Client hostedWCF = new MyWCF.Service1Client();
            string result = hostedWCF.GetData(5);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
