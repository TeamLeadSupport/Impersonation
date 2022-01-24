using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impsersonationDemo.User_Objects
{
    public abstract class BaseUser
    {
        public string fullname { get; set; }
        public List<string> permissions { get; set; }       
        public  int userId { get; set; }
        public virtual  void LogStatement()
        {
            Console.WriteLine($"{userId} {fullname} has logged in!");
        }
    }

}
