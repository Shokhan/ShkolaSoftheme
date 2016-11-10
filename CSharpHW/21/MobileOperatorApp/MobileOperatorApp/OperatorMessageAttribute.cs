using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperatorApp
{
    public class OperatorMessageAttribute : Attribute
    {
        public enum MessageType { Info, Warn };
        public MessageType TypeOfMessage { get; set; }

      
        public OperatorMessageAttribute(MessageType TypeOfMessage)
        {
            this.TypeOfMessage = TypeOfMessage;
        }

        public OperatorMessageAttribute() { }
    }
}
