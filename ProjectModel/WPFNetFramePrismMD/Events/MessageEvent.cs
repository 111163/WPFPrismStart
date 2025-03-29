using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNetFramePrismMD.Events
{
    public class MessageEvent : PubSubEvent<MessageModel>
    {
    }
    public class MessageModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
        public bool IsEnter { get; set; }
    }
}
