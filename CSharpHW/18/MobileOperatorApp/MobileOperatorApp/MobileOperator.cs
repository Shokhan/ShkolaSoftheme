using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperatorApp
{
    static class MobileOperator
    {
        static private List<MobileAccount> _subscribers = new List<MobileAccount>();
        public static string RedirectCall(object sender, string phoneNum, string txt = "")
        {
            var Sender = (MobileAccount) sender;

            for (int i = 0; i < _subscribers.Count; ++i)
            {
                if (_subscribers[i].PhoneNum == phoneNum)
                {
                    _subscribers[i].GetCall(Sender);
                    return "Connection successful.";
                }
            }

            return "Invalid number";
        }

        public static string RedirectSMS(object sender, string phoneNum, string text = "")
        {
            var Sender = (MobileAccount)sender;

            for (int i = 0; i < _subscribers.Count; ++i)
            {
                if (_subscribers[i].PhoneNum == phoneNum)
                {
                    _subscribers[i].GetMessage(Sender, text);
                    return "Message is sent.";
                }
            }

            return "Message can not be sent!!";
        }

        public static void AddSubscriber(MobileAccount sub)
        {
            _subscribers.Add(sub);
        }
    }
}
