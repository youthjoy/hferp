using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using QX.IMessage;
namespace QX.MessageHostCol
{
    class Program
    {
        static void Main(string[] args)
        {
            //注册tcp通道进行消息对象的传输
            TcpChannel tcp = new TcpChannel(8085);
            //注册通道
            ChannelServices.RegisterChannel(tcp, false);

            //将服务端的某个对象注册为已知类型，方便客户端调用
            RemotingConfiguration.RegisterWellKnownServiceType
               (
               typeof(MessageHelper),
               "SendMsg",
               WellKnownObjectMode.Singleton
               );


            System.Console.WriteLine("服务器正在等待信息,按任意键退出！");
            System.Console.ReadLine();
        }
    }
}
