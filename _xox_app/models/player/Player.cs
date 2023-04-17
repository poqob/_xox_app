using _xox_app.game;
using System;


namespace _xox_app.models.user
{
     public class Player : APlayer
    {
        // side must be x or o
        public Player(String userName,String userID,Sides side) : base(userName,userID,side) 
        {
            
        }

        public override String makeMove(int[] indexes)
        {
            return GameBoard.move(indexes,this);
        }
    }
}
