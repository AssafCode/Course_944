using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class MyCallBack : IService1Callback
    {
        public void CallbackFunction(string str)
        {
            Console.WriteLine(str);
        }
    }
}
