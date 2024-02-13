using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoguGame
{
    internal class Spot
    {
        private int x;
        private int y;
        private Piece piece;

        public Spot(int x, int y)
        {
            this.x = x;
            this.y = y;
            piece = null;
        }
        public Spot(int x, int y, Piece piece)
        {
            this.x = x;
            this.y = y;
            this.piece = piece;
        }
        public int X {  
            get { return x; } 
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public void setPiece(Piece piece) {  this.piece = piece; }
        public Piece getPiece() {  return piece; }

    }
}
