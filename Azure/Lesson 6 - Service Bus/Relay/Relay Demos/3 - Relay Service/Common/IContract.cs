using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CommonContract
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        string Echo(string input);
    }
}
