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
            data.currentLand.isRevealed = true;
        }
    }
}
