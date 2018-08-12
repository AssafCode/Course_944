using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        Dictionary<string, OperationContext> contextList = new Dictionary<string, OperationContext>();



        public void NormalFunction(string message)
        {
            if (!contextList.ContainsKey(OperationContext.Current.SessionId))
                contextList.Add(OperationContext.Current.SessionId, OperationContext.Current);
            foreach (OperationContext op in contextList.Values)
            {
                IMyContractCallback callBack = op.GetCallbackChannel<IMyContractCallback>();
                callBack.CallbackFunction(message);
            }
            
        }
    }
}
