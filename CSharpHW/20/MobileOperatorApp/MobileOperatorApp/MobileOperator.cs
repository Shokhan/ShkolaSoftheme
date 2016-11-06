using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperatorApp
{
    static class MobileOperator
    {
        private static List<MobileAccount> _subscribers = new List<MobileAccount>();

        private static List<string> _callHistory = new List<string>();


        public static string RedirectCall(MobileAccount sender, string phoneNum, string txt = "")
        {
            string conFail = "Connection failed.";
            if(sender.Money == 0)
            {
                SendWarnMessage("You do not have money", sender.PhoneNum);
                return conFail;
            }

            string connectionInfo = string.Format("Subscriber {0}  called to {1}. ", sender.PhoneNum, phoneNum);

            var resultIter = (from subs in _subscribers
                             where subs.PhoneNum == phoneNum
                             select subs).GetEnumerator();
            resultIter.MoveNext();
            var subscriber = resultIter.Current;

            if (subscriber != null)
            {
                subscriber.GetCall(sender);
                string success = "Connection successful.";
                _callHistory.Add(connectionInfo + success);
                return success;
            }

            
            _callHistory.Add(connectionInfo + conFail);
            return conFail;
        }

        public static string RedirectSMS(MobileAccount Sender, string phoneNum, string text = "")
        {

            var resultIter = (from subs in _subscribers
                              where subs.PhoneNum == phoneNum
                              select subs).GetEnumerator();
            resultIter.MoveNext();
            var subscriber = resultIter.Current;

            if (subscriber != null)
            {
                subscriber.GetMessage(Sender, text);
                return "Message is sent.";
            }

            return "Message can not be sent!!";
        }

        public static void AddSubscriber(MobileAccount sub)
        {
            _subscribers.Add(sub);
        }

        public static void Top5CallNumbers()
        {
            var top5 = (from sub in _subscribers
                        orderby sub.RateOfInputCalls descending
                        select sub).Take(5);
       
            Console.WriteLine("Top5 call numbers:");
            foreach(var sub in top5)
            {
                Console.WriteLine("{0}: {1}, Number of input calls = {2}.",
                    sub.Name, sub.PhoneNum, sub.RateOfInputCalls.ToString());
            }
        }

        public static void Top5ActiveSubscribers()
        {
            var top5 = (from sub in _subscribers
                        orderby sub.RateOfActivity descending
                        select sub).Take(5);

            Console.WriteLine("Top 5 active subscribers:");
            foreach(var sub in top5)
            {
                Console.WriteLine("{0}: {1}, Activity rate = {2}.",
                    sub.Name, sub.PhoneNum, sub.RateOfActivity.ToString());
            }
        }


        private static void SendOpMessage(string str, string phoneNum, MethodBase m)
        {
            var s = from sub in _subscribers
                    where sub.PhoneNum == phoneNum
                    select sub;
            foreach (var subscriber in s)
            {
                subscriber.GetMessageFromOperator(str, m);
            }
        }

        [OperatorMessage(OperatorMessageAttribute.MessageType.Info)]
        public static void SendInfoMessage(string str, string phoneNum)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            SendOpMessage(str, phoneNum, method);
            
        }

        [OperatorMessage(OperatorMessageAttribute.MessageType.Warn)]
        public static void SendWarnMessage(string str, string phoneNum)
        {
            MethodBase method = MethodBase.GetCurrentMethod();
            SendOpMessage(str, phoneNum, method);
        }
    }
}
