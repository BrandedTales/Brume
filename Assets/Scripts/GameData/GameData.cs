using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    public class GameData 
    {
        //Populate with content I'd want to pass around.

        //Current turn.
        public int turnValue;

        public Piece currentPiece;
        public CardInstance cardOver;

        public GameData(ContentInitialize ct)
        {
            turnValue = ct.turnValue;
        }

        public GameData(Piece piece)
        {
            currentPiece = piece;
        }
    }
}