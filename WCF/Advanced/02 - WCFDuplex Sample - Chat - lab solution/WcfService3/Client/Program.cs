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
            string name;
            string message = string.Empty;
            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();
            name += ": ";
            Console.WriteLine("Write a message !");
            MyCallBack obj = new MyCallBack();
            while (message.ToLower() != "exit")
            {
                message = Console.ReadLine();
                obj.CallService(message);
            }
            obj.Dispose();

        }
    }
}
