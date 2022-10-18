using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Game game;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(this, tableLayoutPanel1);
            game.startGame();
        }

        private Point GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return Point.Empty;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void cellClick(object sender, EventArgs e)
        {
            Point cellPos = GetRowColIndex(tableLayoutPanel1, tableLayoutPanel1.PointToClient(Cursor.Position));
            game.move(cellPos);
        }
    }
}