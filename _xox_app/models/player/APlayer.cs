using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _xox_app.models.user
{
    public abstract class APlayer : AUser
    {
        protected char side;
        public APlayer(String userName, String userID,char side) : base(userName, userID) { this.side = side; }
        
        abstract public void makeMove();
        public char getSide() { return side; }
        public override string ToString()
        {
            return "side: " + side + "\n" + base.ToString();
        }
    }
}
