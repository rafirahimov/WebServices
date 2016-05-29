using System;
using System.ServiceModel;


namespace WCF_Service
{
    [ServiceContract]
    public interface ITestService
    {

        [OperationContract]
        int Calculate(int a, int b, String operation);

    }
   
}
