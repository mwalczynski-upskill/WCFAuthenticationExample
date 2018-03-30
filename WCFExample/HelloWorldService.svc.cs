using System;

namespace WCFExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloWorldService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HelloWorldService.svc or HelloWorldService.svc.cs at the Solution Explorer and start debugging.
    public class HelloWorldService : IHelloWorldService
    {
        public string GetData()
        {
            return "Hello WCF Authentication";
        }
    }
}
