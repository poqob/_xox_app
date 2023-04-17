using _xox_app.game;
using System;

namespace _xox_app.models.user
{
    public abstract class APlayer : AUser
    {
        protected String side;

        protected PlayerStates state;
        public APlayer(String userName, String userID, Sides side) : base(userName, userID)
        {
            this.side = side.ToString();
        }

      

        public abstract String makeMove(int[] indexes);
        public void setState(PlayerStates state) { this.state = state; }
        public PlayerStates getState() { return state; }
        public String getSide() { return side; }
        public override String ToString()
        {
            return "side: " + side + "\n" + base.ToString();
        }
    }
}
