using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MathChessOnline
{
    class Board
    {
        private Piece[,] pieces;
        public Board()
        {
            // set the pieces size
            Piece.size = Utilities.pieceSize;
            //initial the pieces
            initPiece();
        }
        public void initPiece()
        {
            pieces = new Piece[11, 9];
        }
        public void draw(Graphics g)
        {
            //draw the game board

            drawBoard(g);
        }
        public void drawBoard(Graphics g)
        {
            //draw the vertical lines

            for (int i = 0; i < 10; i++)         
            {
                g.DrawLine(Utilities.boardLinesPen, Piece.size * i, 0, Piece.size * i, Piece.size * 11);
            }
            //draw the horizontal lines

            for (int i = 0; i < 12; i++)         
            {
                g.DrawLine(Utilities.boardLinesPen, 0, Piece.size * i, Piece.size*9, Piece.size*i);
            }
            //draw the diagorial lines

            g.DrawLine(Utilities.boardLinesPen, Piece.size * 4, Piece.size, Piece.size * 5, Piece.size * 2);
            g.DrawLine(Utilities.boardLinesPen, Piece.size * 5, Piece.size, Piece.size * 4, Piece.size * 2);
            g.DrawLine(Utilities.boardLinesPen, Piece.size * 4, Piece.size*10, Piece.size * 5, Piece.size * 9);
            g.DrawLine(Utilities.boardLinesPen, Piece.size * 4, Piece.size*9, Piece.size * 5, Piece.size * 10);
        }
        public void drawPiece(Graphics g)
        {

        }
    }
}
