using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace MathChessOnline
{
    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
            : base()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}
