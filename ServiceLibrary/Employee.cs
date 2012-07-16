using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceLibrary
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Id;
        [DataMember]
        public string FullName;
    }
}
