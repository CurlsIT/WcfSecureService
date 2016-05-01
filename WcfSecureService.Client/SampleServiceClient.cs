using System.ServiceModel;

namespace WcfSecureService.Client
{
    internal class SampleServiceClient:ClientBase<ISampleService>, ISampleService
    {
        public string Hello(string name) => Channel.Hello(name);
    }
}
