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
        public void setX(int x) { this.x = x;}
        public int getX() { return x; }
        public void setY(int y) { this.y = y; }
        public int getY() { return y; }
        public void setPiece(Piece piece) {  this.piece = piece; }
        public Piece getPiece() {  return piece; }

    }
}
