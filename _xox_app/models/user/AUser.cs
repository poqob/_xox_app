using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _xox_app
{
    abstract class AUser
    {
        private String userName;
        private String userID;
       

        public AUser(String userName,String userID)
        {
            this.userID = userID;
            this.userName = userName;
        }
    }
}
