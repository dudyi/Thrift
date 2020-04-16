/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：dudingyi                                             
*│　版   本：1.0                                                 
*│　创建时间：2020/4/15 15:13:53                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: ThriftServer                                   
*│　类   名：MySampleService                                      
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftServer
{
    using System.Collections.Generic;
    using ThriftClassLibrary;

    public class MySampleService : SampleService.Iface
    {
        public ServiceVersion GetVersion()
        {
            System.Console.WriteLine("have a request GetVersion()");
            return new ServiceVersion()
            {
                Name = "My Sample Service",
                Version = "0.0.1.20"
            };
        }

        public List<string> SayHello(string name)
        {
            System.Console.WriteLine("have a request SayHello(" + name + ")");
            return new List<string>()
            {
                $"你好 {name}",
                $"Hello {name}",
                $"Hola {name}",
                $"Bonjour {name}",
                $"こんにちは {name}",
                $"hallo {name}"
            };
        }
    }
}
