using System;
using System.ServiceModel;

namespace GettingStartedLib
{

    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double number1, double number2);
        [OperationContract]
        double Subtract(double number1, double number2);
        [OperationContract]
        double Multiply(double number1, double number2);
        [OperationContract]
        double Divide(double number1, double number2);



    }

}