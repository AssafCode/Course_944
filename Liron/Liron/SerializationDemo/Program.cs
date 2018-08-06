using SerializationDemo.MyNewsItemService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "bmw.car";
            //BinaryFormatter formatter = new BinaryFormatter();
            SoapFormatter formatter = new SoapFormatter();

            using (var fs = File.Create(fileName))
            {
                var newCar = new Car()
                {
                    Id = 1,
                    Brand = "BMW",
                    Color = "White",
                    OwnerName = "Liron"
                };
                formatter.Serialize(fs, newCar);
            }

            using (var fs = File.Open(fileName, FileMode.Open))
            {
                var restoredCAr = (Car)formatter.Deserialize(fs);
            }

            GetWebServiceData();
        }

        private static void GetWebServiceData()
        {
            WebService1SoapClient svc = new WebService1SoapClient();
            var top10Items = svc.GetTopItems(10);
        }
    }

    [Serializable]
    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        [NonSerialized]
        public string OwnerName;
    }

}
