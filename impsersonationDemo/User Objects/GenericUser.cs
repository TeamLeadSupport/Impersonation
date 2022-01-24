using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impsersonationDemo.User_Objects
{
    public class GenericUser : BaseUser
    {          
        public GenericUser(int userId, string fullname, List<string> permission )
        {
            this.userId = userId;
            this.fullname = fullname;           
            this.permissions = permission;
        }
    }
}
