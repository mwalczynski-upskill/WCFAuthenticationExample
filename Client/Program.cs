using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ServiceReference.HelloWorldServiceClient())
            {
                client.ClientCredentials.UserName.UserName = "bardzo";
                client.ClientCredentials.UserName.Password = "tajne";
                Console.WriteLine(client.GetData());
            }
            Console.ReadLine();
        }
    }
}
