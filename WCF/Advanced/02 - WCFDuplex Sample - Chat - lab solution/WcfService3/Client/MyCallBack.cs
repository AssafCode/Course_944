using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class MyCallBack : IService1Callback,IDisposable
    {
        Service1Client proxy;

        public void CallService(string message)
        {
            InstanceContext context = new InstanceContext(this);
            proxy = new Service1Client(context);
            proxy.NormalFunction(message);
        }

        public void CallbackFunction(string str)
        {
            Console.WriteLine(str);
        }

        public void Dispose()
        {
            proxy.Close();
        }
    }
}
