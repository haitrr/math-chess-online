using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MathChessOnline
{
    class Game
    {
        Board board;
        public Game()
        {
            board = new Board();
        }
        public void draw(Graphics g)
        {
            board.draw(g);
        }
    }
}
