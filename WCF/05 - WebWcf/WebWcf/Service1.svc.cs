using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Stream GetData(string value)
        {
            return new MemoryStream(Encoding.UTF8.GetBytes("You entered: {0}"+ value));
        }
        
        public Stream GetEmptyData()
        {
            return new MemoryStream(Encoding.UTF8.GetBytes("<html><body>Invoked 1111111<input type='button'/></body></html>"));
        }
    }
}
