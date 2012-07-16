using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract, FaultContract(typeof(ErrorData))]
        Employee GetEmployee(int id);

        [OperationContract, FaultContract(typeof(ErrorData))]
        void MethodThatFails();

        [OperationContract, FaultContract(typeof(ErrorData))]
        void MethodFailsUnexpected();
    }
}
