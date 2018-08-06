using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoBG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker bw1 = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();

            bw1.DoWork += (s, e) =>
            {
                var bw = (BackgroundWorker)s;
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(1000);
                    bw.ReportProgress(i * 10);

                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                e.Result = new LuckyMachine().Number.ToString();
            };

            bw1.ProgressChanged += (s, e) =>
            {
                pb.Value = e.ProgressPercentage;
            };

            bw1.RunWorkerCompleted += (s, e) =>
            {
                if (!e.Cancelled)
                    txtNumber.Text = e.Result.ToString();
                else
                    txtNumber.Text = "Cancelled! :(";
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bw1.WorkerSupportsCancellation = true;
            bw1.WorkerReportsProgress = true;
            bw1.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            bw1.CancelAsync();
        }
    }
}
