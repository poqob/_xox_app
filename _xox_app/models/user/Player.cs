﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _xox_app.models.user
{
     class Player : APlayer
    {
        // side must be x or o
        Player(String userName,String userID,char side) : base(userName,userID,side) 
        {
   
        }

        private void computeBoard() { }

        public override void makeMove()
        {
            throw new NotImplementedException();
        }
    }
}
