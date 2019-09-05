using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/GameData/Land")]
    public class Land : Piece
    {
        public bool isRevealed;

        public void InitializePiece(LandContent lc)
        {
            cardPortrait = lc.cardPortrait;
            name = lc.name;
            flavor = lc.flavor;
            gameProperties = lc.gameProperties;

        }

    }
}