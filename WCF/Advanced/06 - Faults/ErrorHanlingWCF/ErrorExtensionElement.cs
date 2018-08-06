using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;

namespace ErrorHanlingWCF
{
    public class ErrorExtensionElement : BehaviorExtensionElement
    {
        public ErrorExtensionElement()
        {

        }
        public override Type BehaviorType
        {
            get
            {
                return typeof(ErrorServiceBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new ErrorServiceBehavior();
        }
    }
}