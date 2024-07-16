using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            var result = client.GetData(123);
            Console.WriteLine(result);

            var composite = new ServiceReference1.CompositeType
            {
                BoolValue = true,
                StringValue = "Test"
            };
            var compositeResult = client.GetDataUsingDataContract(composite);
            Console.WriteLine(compositeResult.StringValue);

            client.Close();
        }
    }
}
