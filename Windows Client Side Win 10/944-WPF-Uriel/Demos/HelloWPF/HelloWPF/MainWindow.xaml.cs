﻿using System;
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

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // parse the xaml

            //for (int i = 0; i < 10; i++)
            //{

            //    Button b = new Button();
            //    b.Content = "Hello";
            //    b.Background = Brushes.Red;
            //    mainPanel.Children.Add(b);
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
