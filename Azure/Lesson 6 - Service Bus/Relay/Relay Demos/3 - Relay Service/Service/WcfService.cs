using CommonContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RelayExample
{
    
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class WcfService : IContract
    {
        public string Echo(string input)
        {
            Console.WriteLine($"Call received with input {input}");
            return input;
        }
    }
}
