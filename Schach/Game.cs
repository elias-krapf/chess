using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Schach
{
    public class Game
    {
        private Form1 form1;
        private TableLayoutPanel tableLayoutPanel;
        
        Dictionary<Position, Piece> piecePositions = new Dictionary<Position, Piece>();
        
        public Game(Form1 form1, TableLayoutPanel tableLayoutPanel)
        {
            this.form1 = form1;
            this.tableLayoutPanel = tableLayoutPanel;
            
             piecePositions.Add(new Position(0,0), new Piece(Team.WHITE, Pieces.ROOK));
            piecePositions.Add(new Position(0,1), new Piece(Team.WHITE, Pieces.KNIGHT));
            piecePositions.Add(new Position(0,2), new Piece(Team.WHITE, Pieces.BISHOP));
            piecePositions.Add(new Position(0,3), new Piece(Team.WHITE, Pieces.KING));
            piecePositions.Add(new Position(0,4), new Piece(Team.WHITE, Pieces.QUEEN));
            piecePositions.Add(new Position(0,5), new Piece(Team.WHITE, Pieces.BISHOP));
            piecePositions.Add(new Position(0,6), new Piece(Team.WHITE, Pieces.KNIGHT));
            piecePositions.Add(new Position(0,7), new Piece(Team.WHITE, Pieces.ROOK));
            
            piecePositions.Add(new Position(1,0), new Piece(Team.WHITE, Pieces.PAWN));
            piecePositions.Add(new Position(1,1), new Piece(Team.WHITE, Pieces.PAWN));
            piecePositions.Add(new Position(1,2), new Piece(Team.WHITE, Pieces.PAWN));
            piecePositions.Add(new Position(1,3), new Piece(Team.WHITE, Pieces.PAWN));
            piecePositions.Add(new Position(1,4), new Piece(Team.WHITE, Pieces.PAWN));
            piecePositions.Add(new Position(1,5), new Piece(Team.WHITE, Pieces.PAWN));
            piecePositions.Add(new Position(1,6), new Piece(Team.WHITE, Pieces.PAWN));
            piecePositions.Add(new Position(1,7), new Piece(Team.WHITE, Pieces.PAWN));
            
            
            piecePositions.Add(new Position(7,0), new Piece(Team.BLACK, Pieces.ROOK));
            piecePositions.Add(new Position(7,1), new Piece(Team.BLACK, Pieces.KNIGHT));
            piecePositions.Add(new Position(7,2), new Piece(Team.BLACK, Pieces.BISHOP));
            piecePositions.Add(new Position(7,3), new Piece(Team.BLACK, Pieces.KING));
            piecePositions.Add(new Position(7,4), new Piece(Team.BLACK, Pieces.QUEEN));
            piecePositions.Add(new Position(7,5), new Piece(Team.BLACK, Pieces.BISHOP));
            piecePositions.Add(new Position(7,6), new Piece(Team.BLACK, Pieces.KNIGHT));
            piecePositions.Add(new Position(7,7), new Piece(Team.BLACK, Pieces.ROOK));
            
            piecePositions.Add(new Position(6,0), new Piece(Team.BLACK, Pieces.PAWN));
            piecePositions.Add(new Position(6,1), new Piece(Team.BLACK, Pieces.PAWN));
            piecePositions.Add(new Position(6,2), new Piece(Team.BLACK, Pieces.PAWN));
            piecePositions.Add(new Position(6,3), new Piece(Team.BLACK, Pieces.PAWN));
            piecePositions.Add(new Position(6,4), new Piece(Team.BLACK, Pieces.PAWN));
            piecePositions.Add(new Position(6,5), new Piece(Team.BLACK, Pieces.PAWN));
            piecePositions.Add(new Position(6,6), new Piece(Team.BLACK, Pieces.PAWN));
            piecePositions.Add(new Position(6,7), new Piece(Team.BLACK, Pieces.PAWN));
        }

        public void startGame()
        {
            this.resetPeaces();
            
        }

        private Piece getPieceOfPosition(int column, int row)
        {
            foreach (KeyValuePair<Position, Piece> meta in piecePositions)
            {
                if (meta.Key.row == row && meta.Key.column == column)
                {
                    return meta.Value;
                }
            }

            return null;
        }

        private void movePiece(object sender, EventArgs e)
        {
          
        }
        
        public void move(Point point)
        {

            Piece piece = this.getPieceOfPosition(point.X, point.Y);
            
            if (piece != null)
            {
              
            }
            
          
        }
        
        private void resetPeaces()
        {

            /*
             * 1=BAUER
             * 2=TURM
             * 3=SPRINGER
             * 4=LÄUFER
             * 5=DAME
             * 6=KÖNIG
             */
            
            foreach (KeyValuePair<Position, Piece> meta in piecePositions)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(@"C:\Users\IFA2020-19\Pictures\SCHACH\" + meta.Value.pieces + ".png");
                this.tableLayoutPanel.Controls.Add(pictureBox, meta.Key.column, meta.Key.row);
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(1);   
                pictureBox.Click += new EventHandler(movePiece);
            }
        }
    }
}