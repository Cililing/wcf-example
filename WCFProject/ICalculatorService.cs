using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        double Add(double n1, double n2);

        [OperationContract]
        double Substract(double n1, double n2);

        [OperationContract]
        double AddToMemory(double n2);
    }
    
}
