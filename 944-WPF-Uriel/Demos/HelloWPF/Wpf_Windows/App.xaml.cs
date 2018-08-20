using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf_Windows
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //log

            // whicg windoe to open ? 



            Window1 w = new Window1();
            Window2 w2 = new Window2(12);
            w.Show();
            w2.Show();
        }
    }
}
