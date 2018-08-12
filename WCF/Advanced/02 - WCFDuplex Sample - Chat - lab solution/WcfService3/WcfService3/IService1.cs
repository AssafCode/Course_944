using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IMyContractCallback))]
    public interface IService1
    {
        [OperationContract(IsOneWay =true)]
        void NormalFunction(string message);
    }

    public interface IMyContractCallback
    {
        [OperationContract(IsOneWay = true)]
        void CallbackFunction(string str);
    }

    
}
