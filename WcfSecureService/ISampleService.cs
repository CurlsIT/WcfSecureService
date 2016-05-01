using System.ServiceModel;

namespace WcfSecureService
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Hello(string name);
    }
}
