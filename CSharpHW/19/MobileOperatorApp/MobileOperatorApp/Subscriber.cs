using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperatorApp
{
    public class MobileAccount
    {
        public delegate string Connection(MobileAccount sender, string num, string txt = "");

        public event Connection Call;
        public event Connection SendSMS;
        private double _rateOfActivity = 0;
        private int _rateOfInputCalls = 0;
        public  string Name { get; }
        public string PhoneNum { get; }
        public double RateOfActivity { get { return _rateOfActivity; } }
        public int RateOfInputCalls { get { return _rateOfInputCalls; } }

        public MobileAccount(string name, string num)
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
            Call += MobileOperator.RedirectCall;
            SendSMS += MobileOperator.RedirectSMS;
        }

        public void CallTo(string num)
        {
            Console.WriteLine(Call(this, num));
            _rateOfActivity += 1.0;
        }

        public void SendMessage(string sms, string num)
        {
            Console.WriteLine(SendSMS(this, num, sms));
            _rateOfActivity += 0.5;
        }

        public void GetCall(MobileAccount sub)
        {
            ++_rateOfInputCalls;
            Console.WriteLine("\nSubscriber {0} = {1} got call from {2} = {3}", Name, PhoneNum,sub.Name, sub.PhoneNum);
        }

        public void GetMessage(MobileAccount sub, string message)
        {
            Console.WriteLine("\nSubscriber {0} = {1} has got message from {2}.\n Message:\n{3}",
                Name, PhoneNum, sub.PhoneNum, message);
        }
    }
}
