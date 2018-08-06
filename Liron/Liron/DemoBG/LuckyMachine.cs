using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DemoBG
{
    class LuckyMachine
    {
        Random rnd = new Random();
        public int Number
        {
            get
            {
                return rnd.Next(1,100);
            }
        }

    }
}
