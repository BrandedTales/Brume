using UnityEngine;
using System.Collections;
using System;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Action/Reveal Land")]
    public class ActionRevealLand : GameAction
    {
        public LandList landList;

        public override void Execute(GameData data)
        {
            if ((data.currentPiece != null) && (data.currentPiece is Land))
            {
                Land land = data.currentPiece as Land;
                land.isActive = true;
                land.isRevealed = true;

                data.currentPiece = land;

            }
        }
    }
}
