using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.IMessage
{
    public class MessageHelper : MarshalByRefObject
    {
        public void SendMsg(string mobile, string content)
        {

            GSMModem.GSMModem modem = new GSMModem.GSMModem();
            modem.ComPort = System.Configuration.ConfigurationSettings.AppSettings["COMStr"];
            modem.BaudRate = 9600;
            try
            {
                if (!modem.IsOpen)
                {
                    modem.Open();
                    modem.SendMsg(mobile, content);
                    modem.Close();

                }
                else
                {
                    modem.SendMsg(mobile, string.Format(mobile,content));
                    modem.Close();
                }
            }
            catch (Exception ex)
            {
                modem.Close();
            }

            Console.WriteLine("发送一条信息!");
        }
    }
}
