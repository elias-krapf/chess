namespace Schach
{
    public class Piece
    {
        public Team team;
        public Pieces pieces;

        public Piece(Team team, Pieces pieces)
        {
            this.team = team;
            this.pieces = pieces;
        }

    }
}