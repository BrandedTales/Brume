using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/GameData/Hero")]
    public class Hero : Piece
    {
        public bool isDeployed;

        public void InitializePiece(HeroContent hc)
        {
            Debug.Log("Initializing: " + hc.name);
            cardPortrait = hc.cardPortrait;
            token = hc.tokenArt;
            name = hc.name;
            flavor = hc.flavor;
        }

    }
}