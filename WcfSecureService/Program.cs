using System;
using System.ServiceModel;

namespace WcfSecureService
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof(SampleService));
            serviceHost.Open();

            Console.WriteLine("Service started. Press [Enter] to exit.");
            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
