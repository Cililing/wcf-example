using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using CalculatorService;

namespace WCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:80/calculatorService");
            ServiceHost host = new ServiceHost(typeof(CalculatorService.CalculatorService), baseAddress);

            try
            {
                WSHttpBinding binding = new WSHttpBinding();
                host.AddServiceEndpoint(typeof(ICalculatorService), binding, "calculator");

                ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
                serviceMetadataBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(serviceMetadataBehavior);
                host.Open();
                Console.WriteLine("Service is running on: {0}. Press any button to finish.", baseAddress);
                Console.ReadKey();
                host.Close();
            }
            catch (CommunicationException exception)
            {
                Console.WriteLine("Exception occured: {0}", exception);
                host.Abort();
            }
            
        }
    }
}
