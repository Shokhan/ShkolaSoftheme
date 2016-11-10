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
                phoneNum2= "380931412142",
                phoneNum3 = "380931412143";

            MobileAccount s1 = new MobileAccount("John", phoneNum1, 10);
            MobileAccount s2 = new MobileAccount("Dominik", phoneNum2, 10);
            MobileAccount s3 = new MobileAccount("CatDog", phoneNum3, 0);
            MobileOperator.AddSubscriber(s1);
            MobileOperator.AddSubscriber(s2);
            MobileOperator.AddSubscriber(s3);
 

            MobileOperator.AddSubscriber(new MobileAccount("Leo", "380966868665", 15));
            MobileOperator.AddSubscriber(new MobileAccount("Mark", "380967868665", 10));
            MobileOperator.AddSubscriber(new MobileAccount("Lila", "380936868665", 10));
            

            MobileOperator.SerializeData();
          
        }
    }
}
