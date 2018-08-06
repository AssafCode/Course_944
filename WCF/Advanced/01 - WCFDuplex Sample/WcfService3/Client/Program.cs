using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

//Duplex client
namespace Client
{
    class Program
    {

        static Service1Client proxy;

        static void Main(string[] args)
        {
            MyCallBack obj = new MyCallBack();

            InstanceContext context = new InstanceContext(obj);
            proxy = new Service1Client(context);
            proxy.NormalFunction();

            Console.ReadLine();
            proxy.Close();

        }
    }
}
