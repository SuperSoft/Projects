using System;
using System.Collections.Generic;
using System.Linq;
using EasyNetQ;

namespace XMCares.RabbitMQ.Client.Events
{
    public class MessageEventArgs : EventArgs
    {
        public byte[] Bytemessage
        {
            get;
            set;
        }
        public MessageProperties Messagepoperties
        {
            get;
            set;
        }
        public MessageReceivedInfo Messagereceivedinfo
        {
            get;
            set;
        }
    }
}
