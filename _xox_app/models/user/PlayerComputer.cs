using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _xox_app.models.user
{
    class PlayerComputer : APlayer
    {
        // default computer definition
        PlayerComputer (char side) : base("Computer","00000000",side) { }


        public override void makeMove()
        {
            throw new NotImplementedException();
        }
    }
}
