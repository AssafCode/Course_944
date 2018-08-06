using CustomSerializtion.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;

namespace CustomSerializtion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "bankaccount1.account";
            SoapFormatter formatter = new SoapFormatter();

            using (var fs = File.Create(fileName))
            {
                var bankAccount = new BankAccount()
                {
                    Id = 107,
                    BankAddress = "Sela",
                    OwnerFirstName = "Dani",
                    OwnerLasttName = "Din",
                    Password = "12345678"
                };
                formatter.Serialize(fs, bankAccount);
            }

            using (var fs = File.Open(fileName, FileMode.Open))
            {
                var restoredAccount = (BankAccount)formatter.Deserialize(fs);
            }
        }
    }
}
