﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MathChessOnline
{
    class Piece
    {
        public static int size;
        protected int value;
        protected Image image;
        public virtual void drawPiece(Graphics g)  //draw the piece
        {
            //for delivered class
        }

    }
}
