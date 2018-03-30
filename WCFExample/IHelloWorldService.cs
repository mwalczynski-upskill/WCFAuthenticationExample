using System.ServiceModel;

namespace WCFExample
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        string GetData();
    }
}
