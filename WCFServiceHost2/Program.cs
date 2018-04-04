using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using CalculatorService;

namespace WCFServiceHost2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CalculatorService.CalculatorService));

            try
            {
                ServiceEndpoint endpoint1 = host.Description.Endpoints.Find(typeof(ICalculatorService));
                ServiceEndpoint endpoint2 = host.Description.Endpoints.Find(new Uri("http://localhost:80/calculatorService/endpoint2"));
                ServiceEndpoint endpoint3 = host.Description.Endpoints.Find(new Uri("http://localhost:20000/calculatorService/endpoint2"));
                ServiceEndpoint endpoint4 = host.AddServiceEndpoint(
                    typeof(ICalculatorService),
                    new NetTcpBinding(),
                    new Uri("net.tcp://localhost:30000/myTPCService"));

                var endpointsList = new List<ServiceEndpoint>()
                {
                    endpoint1, endpoint2, endpoint3, endpoint4
                };

                Console.WriteLine("Endpoints");
                endpointsList.ForEach(item =>
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("ServiceEndpoint {0}", item?.Name);
                    Console.WriteLine("Binding {0}", item?.Binding.ToString());
                    Console.WriteLine("ListenUri {0}", item?.ListenUri.ToString());
                });

                host.Open();

                ContractDescription contractDescription = ContractDescription.GetContract(typeof(ICalculatorService));
                Console.WriteLine("\tContractInfo");
                Type contractType = contractDescription.ContractType;

                Console.WriteLine("\tName: {0}", contractDescription.Name);
                Console.WriteLine("\tOperations");
                contractDescription.Operations.ToList().ForEach(item =>
                {
                    Console.WriteLine("\t\t{0}", item.Name);
                });


                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException exception)
            {
                Console.WriteLine("Exception: {0}", exception);
                host.Abort();
            }
        }
    }
}
