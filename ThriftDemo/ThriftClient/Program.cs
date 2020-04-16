using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;
using ThriftClassLibrary;

namespace ThriftClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TTransport transport = new TSocket("localhost", 10240);
            transport.Open();

            TProtocol protocol = new TBinaryProtocol(transport);
            SampleService.Client cli = new SampleService.Client(protocol);

            ServiceVersion ver = cli.GetVersion();
            System.Console.WriteLine("Remote Service Version: {0} - v{1}", ver.Name, ver.Version);

            //while (true) {
                var hellos = cli.SayHello("Thrift" + DateTime.Now.ToString());

                foreach (string item in hellos)
                {
                    System.Console.WriteLine(item);
                }

                System.Threading.Thread.Sleep(1000);
            //}

            System.Console.ReadKey();
            transport.Close();
        }
    }
}
