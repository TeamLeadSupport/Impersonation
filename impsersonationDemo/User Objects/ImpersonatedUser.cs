using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impsersonationDemo.User_Objects
{
    public class ImpersonatedUser : BaseUser
    {
        private BaseUser adminUser;      
        private int _userUserId;
        public ImpersonatedUser(BaseUser user , BaseUser AdminUser)
        {
            adminUser = AdminUser;
            this.fullname = user.fullname;            
            this.permissions = user.permissions;
            this.userId = adminUser.userId;
            _userUserId = user.userId;
        }
       
        public override void LogStatement()
        {
            Console.WriteLine($"{adminUser.userId} { adminUser.fullname } is impersonating {_userUserId} {fullname} ");
        }
    }
}
