using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GCNotifications
{
    class Program
    {
        static void Main(string[] args)
        {
            GCNotifier gcn = new GCNotifier();
            gcn.GCApproaches += (s, e) => {
                Console.WriteLine("GC Approaches!");
            };

            gcn.GCCompleted += (s, e) => {
                Console.WriteLine("GC Completed!");
            };

            while (!Console.KeyAvailable)
            {
                //Thread.Sleep(10);
                byte[] arr = new byte[100000];
            }
        }
    }

    class GCNotifier
    {
        private Thread _thread;

        public event EventHandler GCApproaches;
        public event EventHandler GCCompleted;

        public GCNotifier()
        {
            _thread = new Thread(ListenTiGC);
            _thread.Start();
        }

        private void ListenTiGC()
        {
            GC.RegisterForFullGCNotification(10,10);
            while (true)
            {
                GCNotificationStatus status = GC.WaitForFullGCApproach();
                if (status == GCNotificationStatus.Succeeded)
                {
                    GCApproaches?.Invoke(this, EventArgs.Empty);

                    status = GC.WaitForFullGCComplete();
                    if (status == GCNotificationStatus.Succeeded)
                        GCCompleted?.Invoke(this, EventArgs.Empty);
                    else
                        throw new Exception("GC Completion Error!! :(");
                }
                else
                    throw new Exception("GC Approach Error!! :(");
            }
        }
    }
}
