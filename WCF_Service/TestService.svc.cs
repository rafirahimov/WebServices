using System;

namespace WCF_Service
{

    public class TestService : ITestService
    {
        public int Calculate(int a, int b, String operation)
        {
            switch(operation){
                case "+":
                    return a + b;
                    break;
                case "-":
                    return a - b;
                    break;
                case "*":
                    return a * b;
                    break;
                case "/":
                    return a / b;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        

    }
}
