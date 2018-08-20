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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConsumingResources_LabSolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void blueItem_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary dictionary = App.Current.Resources.MergedDictionaries[0];
            dictionary["AppStyle"] = dictionary["BlueButton"];
        }

        private void darkItem_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary dictionary = App.Current.Resources.MergedDictionaries[0];
            dictionary["AppStyle"] = dictionary["DarkButton"];
        }
    }
}
