using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceClient.CalculatorService;

namespace WCFServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculatorServiceClient client = new CalculatorServiceClient();

            var workers = new List<CalculatorServiceClient>()
            {
                new CalculatorServiceClient("WSHttpBinding_ICalculatorService"),
                new CalculatorServiceClient("endpoint2"),
                new CalculatorServiceClient("endpoint3"),
                new CalculatorServiceClient("NetTcpBinding_ICalculatorService")
            };

            workers.ForEach(client =>
            {
                Console.WriteLine("Executing operations on client: {0}", client.Endpoint.ListenUri.ToString());
                Console.WriteLine(client?.Add(0.5d, 0.2d));
                Console.WriteLine(client?.Substract(0.7d, 0.3d));

                Console.WriteLine(client?.AddToMemory(0.1d));
                Console.WriteLine(client?.AddToMemory(0.1d));

                client?.Close();
            });

            workers.ForEach(client =>
            {
                client?.Close();
            });

            Console.ReadKey();
        }
    }
}
