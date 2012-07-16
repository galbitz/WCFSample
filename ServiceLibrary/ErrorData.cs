using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceLibrary
{
    [DataContract]
    public class ErrorData
    {
        [DataMember]
        public int Result;
        [DataMember]
        public string ErrorMessage;
        [DataMember]
        public string ErrorDetails;
    }
}
