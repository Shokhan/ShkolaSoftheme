using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MobileOperatorApp
{
    [Serializable]
    [DataContract]
    [ProtoContract]
    public class MobileAccount
    {
        public delegate string Connection(MobileAccount sender, string num, string txt = "");

        public event Connection Call;
        public event Connection SendSMS;

        [DataMember]
        [ProtoMember(1)]
        public double RateOfActivity { get; set; }
        [ProtoMember(2)]
        [DataMember]
        public int RateOfInputCalls { get; set; }
        [ProtoMember(3)]
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        [ProtoMember(4)]
        public string PhoneNum { get; set; }

        [DataMember]
        [ProtoMember(5)]
        public int Money { get; set; }

        private MobileAccount() { }
        public MobileAccount(string name, string num, int mon)
        {
            if (num.Length != 12)
                throw new InvalidOperationException();

            for (int i = 0; i < num.Length; ++i)
            {
                if (!char.IsDigit(num[i]))
                    throw new InvalidOperationException();
            }

            Name = name;
            PhoneNum = num;
            Money = mon;
            Call += MobileOperator.RedirectCall;
            SendSMS += MobileOperator.RedirectSMS;
        }

        public void CallTo(string num)
        {
            Console.WriteLine(Call(this, num));
            RateOfActivity += 1.0;
            --Money;
        }

        public void SendMessage(string sms, string num)
        {
            Console.WriteLine(SendSMS(this, num, sms));
            RateOfActivity += 0.5;
            --Money;
        }

        public void GetCall(MobileAccount sub)
        {
            ++RateOfInputCalls;
            Console.WriteLine("\nSubscriber {0} = {1} got call from {2} = {3}", Name, PhoneNum,sub.Name, sub.PhoneNum);
        }

        public void GetMessage(MobileAccount sub, string message)
        {
            Console.WriteLine("\nSubscriber {0} = {1} has got message from {2}.\n Message:\n{3}",
                Name, PhoneNum, sub.PhoneNum, message);
        }

        public void GetMessageFromOperator(string str, MethodBase method)
        {
            OperatorMessageAttribute attr =
                (OperatorMessageAttribute)method.GetCustomAttributes(typeof(OperatorMessageAttribute), true)[0];

            if(attr.TypeOfMessage == OperatorMessageAttribute.MessageType.Warn)
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(str);
                Console.ForegroundColor = color;
            }

        }
    }
}
