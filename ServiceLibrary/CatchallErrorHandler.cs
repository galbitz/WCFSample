using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace ServiceLibrary
{
    public class CatchallErrorHandler : IErrorHandler
    {
        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            Exception exception = error as Exception;
            if (exception != null)
            {
                ErrorData data = new ErrorData() {Result = 1, ErrorDetails = "Error:" + exception.Message};
                FaultException<ErrorData> faultException = new FaultException<ErrorData>(data);
                MessageFault messageFault = faultException.CreateMessageFault();
                fault = Message.CreateMessage(version, messageFault, null);
            }
        }

        public bool HandleError(Exception error)
        {
            return error is Exception;
        }
    }
}
