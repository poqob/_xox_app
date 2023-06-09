﻿
using _xox_app.game;
using System;

namespace _xox_app.models.user
{
    public class PlayerComputer : APlayer
    {
        // default computer definition
        public PlayerComputer(Sides side) : base("Computer", "00000000", side) { }


        // compute possibilities of the game and pick best move. (as int array)
        private int[] bestMove()
        {
           // TODO: calculate best move and return it's indexes.














            // will pick best move's indexes from the board.
            return new int[] { 1, 1 };
        }



        public string makeMove()
        {
            return GameBoard.move(bestMove(), this);
        }




        //computer won't make indexed move. instead compute posibilities itself then makes move.
        public override string makeMove(int[] indexes)
        {
            return GameBoard.move(indexes, this);
        }




    }
}
