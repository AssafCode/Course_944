using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_Windows
{
    //custom message box
    public partial class Message : Window
    {
        private Message()
        {
            InitializeComponent();
        }

        private static Message _insta;
        private static Message insta
        {
            get
            {
                if (_insta == null)
                    _insta = new Message();
                return _insta;
            }
        }

        // custom function Show
        public static void Show(string msg)
        {
            insta.text.Text = msg;
            //use windows. Show
            insta.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
