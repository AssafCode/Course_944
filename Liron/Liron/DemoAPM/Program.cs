using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DemoAPM
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (StreamWriter writer = new StreamWriter("demo.txt"))
            //{
            //    for (int i = 0; i < 500000000; i++)
            //    {
            //        writer.WriteLine(i);
            //    }
            //}


            CopyAsync();
        }

        static void CopyAsync()
        {
            FileStream fsReader = new FileStream("demo.txt", FileMode.Open);
            FileStream fsWriter = new FileStream("demo2.txt", FileMode.Create);

            byte[] buffer1 = new byte[8192], buffer2 = new byte[8192];
            IAsyncResult ar1, ar2 = null;

            while (true)
            {
                ar1 = fsReader.BeginRead(buffer1, 0, buffer1.Length, null, null);
                while (!ar1.IsCompleted)
                    Console.Write("R");

                if (ar2 != null)
                {
                    while (!ar2.IsCompleted)
                        Console.Write("W");
                }

                int bytesRead;
                if ((bytesRead = fsReader.EndRead(ar1)) == 0)
                    break;

                if (ar2 != null)
                    fsWriter.EndWrite(ar2);

                Array.Copy(buffer1, buffer2, bytesRead);
                ar2 = fsWriter.BeginWrite(buffer2, 0, bytesRead, null, null);
            }
        }
    }
}
