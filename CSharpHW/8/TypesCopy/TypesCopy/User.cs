using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesCopy
{
    class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }

        public User(int id, string name)
        {
            UserID = id;
            UserName = name;
        }

        public void Show()
        {
            Console.WriteLine("UserId: {0}, UserName: {1};", UserID, UserName);
        }
    }
}
