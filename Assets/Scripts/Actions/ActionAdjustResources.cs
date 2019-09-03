using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Action/Adjust Resources")]
    public  class ActionAdjustResources : GameAction
    {
        public ResourceVariable resourceVariable;
        public int adjustmentValue;
        public bool setToValue = false;

        public override void Execute(GameData data)
        {
            if (setToValue)
                resourceVariable.value = adjustmentValue;
            else
                resourceVariable.value += adjustmentValue;

        }
    }
}