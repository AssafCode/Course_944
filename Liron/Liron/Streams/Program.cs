using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decorator
            //var fileName = "encrypted.dat";
            //string str = "Good morning!! :)";
            //byte[] data = Encoding.ASCII.GetBytes(str);
            //FileStream fs = new FileStream(fileName, FileMode.Create);
            //XorEncryptorStream xor = new XorEncryptorStream(fs, 107);
            //xor.Write(data, 0, data.Length);
            //xor.Close();
            //fs.Close();

            //fs = new FileStream(fileName, FileMode.Open);
            //xor = new XorEncryptorStream(fs, 107);

            //var readBuffer = new byte[str.Length];
            //Console.WriteLine($"Bytes read: {xor.Read(readBuffer, 0, readBuffer.Length)}");
            //xor.Close();
            //fs.Close();

            //Console.WriteLine($"data: {Encoding.ASCII.GetString(readBuffer)}");

            ////var excryptedData = File.ReadAllText(fileName);
            ////Console.WriteLine(excryptedData);

            //Composite
            FileStream fs1 = new FileStream("f1.log", FileMode.Create);
            FileStream fs2 = new FileStream("f2.log", FileMode.Create);
            FileStream fs3 = new FileStream("f3.log", FileMode.Create);
            MemoryStream ms1 = new MemoryStream();

            var xor = new XorEncryptorStream(fs1, 107);
            LoggerCompositeSTream logger = new LoggerCompositeSTream(ms1, fs2, fs3 ,Console.OpenStandardOutput(), xor);
            var data2 = Encoding.ASCII.GetBytes("Hello! :))");
            logger.Write(data2, 0, data2.Length);
            xor.Close();
            logger.Close();

            Console.ReadKey();
        }
    }
}
