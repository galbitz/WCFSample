using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceClient.ServiceReference1;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.EmployeeServiceClient client = new ServiceReference1.EmployeeServiceClient();
            client.ClientCredentials.UserName.UserName = "intelex";
            client.ClientCredentials.UserName.Password = "password";

            var retval = client.Echo();
            Console.WriteLine(retval);

        }
    }
}
