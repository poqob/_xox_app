using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _xox_app.models.user
{
    abstract class APlayer : AUser
    {
        private char side;
        public APlayer(String userName, String userID,char side) : base(userName, userID) { this.side = side; }

        abstract public void makeMove();
    }
}
