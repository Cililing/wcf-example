using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalculatorService : ICalculatorService
    {
        double memory = 0.0d;

        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Substract(double n1, double n2)
        {
            return n1 - n2;
        }

        public double AddToMemory(double n2)
        {
            memory += n2;
            return memory;
        }
    }
}
