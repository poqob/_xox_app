using _xox_app.game;
using System;

namespace _xox_app.models.user
{
    public abstract class APlayer : AUser
    {
        protected String side;
        public APlayer(String userName, String userID, Sides side) : base(userName, userID)
        {
            this.side = side.ToString();
        }

        public abstract String makeMove(int[] indexes);
        public String getSide() { return side; }
        public override String ToString()
        {
            return "side: " + side + "\n" + base.ToString();
        }
    }
}
