namespace WcfSecureService
{
    class SampleService : ISampleService
    {
        public string Hello(string name) => $"Hello {name}!";
    }
}
