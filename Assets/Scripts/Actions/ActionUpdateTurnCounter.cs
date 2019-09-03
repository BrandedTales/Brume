using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Action/Update Turn Counter")]
    public  class ActionUpdateTurnCounter : GameAction
    {
        public IntVariable turnCounter;

        public override void Execute(GameData data)
        {
            turnCounter.value++;
        }
    }
}