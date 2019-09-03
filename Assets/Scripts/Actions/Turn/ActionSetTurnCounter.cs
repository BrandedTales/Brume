using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Action/Set Turn Counter")]
    public  class ActionSetTurnCounter : GameAction
    {
        public IntVariable turnCounter;

        public override void Execute(GameData data)
        {
            turnCounter.value = data.turnValue;
        }
    }
}