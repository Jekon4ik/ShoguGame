using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoguGame
{
    public class Piece
    {
        private PieceType pieceType;
        private bool isWhite;
        private bool isAlive;

        public void setPieceType(PieceType pieceType) { this.pieceType = pieceType; }
        public PieceType getPiece() { return pieceType; }
        public bool IsWhite
        {
            get { return isWhite; }
            set { isWhite = value; }
        }
        public bool IsAlive
        {
            get { return isAlive; }
            set {isAlive = value; }
        }
    }
}
