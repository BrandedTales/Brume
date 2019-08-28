using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Handlers/Land/RightClick")]
    public  class LandRightHandler : LandInputHandler
    {
        public override void Execute(Land land)
        {
            Debug.Log("Create menu canvas!");
        }
    }
}