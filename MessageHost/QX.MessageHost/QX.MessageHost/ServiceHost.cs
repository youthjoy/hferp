using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using QX.IMessage;

namespace QX.MessageHost
{
    public partial class ServiceHost : Form
    {
        public ServiceHost()
        {
            InitializeComponent();

            this.Load += new EventHandler(ServiceHost_Load);
        }

        void ServiceHost_Load(object sender, EventArgs e)
        {
            //注册tcp通道进行消息对象的传输
            TcpChannel tcp = new TcpChannel(8085);
            //注册通道
            ChannelServices.RegisterChannel(tcp, true);

            //将服务端的某个对象注册为已知类型，方便客户端调用
            RemotingConfiguration.RegisterWellKnownServiceType
               (
               typeof(MessageHelper),
               "SendMsg",
               WellKnownObjectMode.Singleton
               );

        }
    }
}
