using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Server;
using Thrift.Transport;
using ThriftClassLibrary;

namespace ThriftServer
{
    class Program
    {
        static void Main(string[] args)
        {
            MySampleService service = new MySampleService();

            SampleService.Processor processor = new SampleService.Processor(service);

            TServerTransport serverTransport = new TServerSocket(10240);
            TServer server = new TThreadPoolServer(processor, serverTransport);
            System.Console.WriteLine("server listening at tcp://localhost:10240/");
            //绑定
            server.setEventHandler(new ServerTServerEventHandler());

            server.Serve();
        }
    }

    class ServerTServerEventHandler : TServerEventHandler
    {
        /// <summary>
        /// 服务成功启动后执行
        /// </summary>
        public void preServe()
        {
            System.Console.WriteLine("Start server");
        }

        /// <summary>
        /// 创建Context的时候，触发
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public object createContext(TProtocol input, TProtocol output)
        {
            TSocket socket = (TSocket)input.Transport;
            IPEndPoint ip = (IPEndPoint)socket.TcpClient.Client.RemoteEndPoint;

            System.Console.WriteLine("");
            return null;
        }

        /// <summary>
        /// 删除Context的时候，触发
        /// </summary>
        /// <param name="serverContext"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        public void deleteContext(object serverContext, TProtocol input, TProtocol output)
        {
            System.Console.WriteLine("");
        }

        /// <summary>
        /// 调用RPC服务的时候触发
        /// </summary>
        /// <param name="serverContext"></param>
        /// <param name="transport"></param>
        public void processContext(object serverContext, TTransport transport)
        {
            TSocket socket = (TSocket)transport;
            IPEndPoint ip = (IPEndPoint)socket.TcpClient.Client.RemoteEndPoint;

            System.Console.WriteLine("");
        }
    }
}
