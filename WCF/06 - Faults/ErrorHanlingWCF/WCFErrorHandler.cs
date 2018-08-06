using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace ErrorHanlingWCF
{
    public class WCFErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            return false;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            FaultException<string> ex = new FaultException<string>("Dolev","Shapira");
            MessageFault faultMessage = ex.CreateMessageFault();
            fault = Message.CreateMessage(version, faultMessage, ex.Action);
        }
    }
}