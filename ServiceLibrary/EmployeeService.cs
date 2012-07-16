using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    [ServiceBehavior(InstanceContextMode =  InstanceContextMode.Single)]
    [ErrorHandlingBehavior]
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee(int id)
        {
            return new Employee() {Id = "1", FullName = "John Doe"};
        }

        public void MethodThatFails()
        {
            var returnData = new ErrorData();
            returnData.Result = 1;
            returnData.ErrorMessage = "Errormessage";
            throw new FaultException<ErrorData>(returnData);
        }

        public void MethodFailsUnexpected()
        {
            throw new Exception("Unexpected error");
        }
    }
}
