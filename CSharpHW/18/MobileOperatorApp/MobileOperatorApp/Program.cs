using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNum1 = "380931426141",
                phoneNum2= "380931412142";
            MobileAccount s1 = new MobileAccount("John", phoneNum1);
            MobileAccount s2 = new MobileAccount("Dominik", phoneNum2);

            MobileOperator.AddSubscriber(s1);
            MobileOperator.AddSubscriber(s2);

            s1.CallTo(phoneNum2);
            s2.SendMessage("Some message", phoneNum1);
        }
    }
}
