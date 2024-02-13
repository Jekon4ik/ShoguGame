using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoguGame
{
    abstract class King:PieceType
    {
        private int amountOnTheBoard = 2;

        public bool IsLegalMove(Board board, Spot startSpot, Spot finishSpot)
        {
            if(finishSpot.getPiece().IsWhite == startSpot.getPiece().IsWhite) return false;

            int resX = Math.Abs(finishSpot.X - startSpot.X);
            int resY = Math.Abs(finishSpot.Y - startSpot.Y);
            if (resX == 1 || resY == 1) return true;
            if (resX == 0 || resY == 1) return true;
            if (resX == 1 || resY == 0) return true;
            return false;
        }

    }
}
