using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeakReferences
{
    class Program
    {
        static WeakReference wr1 = null;
        static void Main(string[] args)
        {
            Car c1 = new Car() { Id = 1, Brand = "BMW" };
            wr1 = new WeakReference(c1);

            Car c1car = (Car)wr1.Target;

        }
    }

    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
    }
}
