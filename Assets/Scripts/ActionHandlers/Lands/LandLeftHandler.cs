using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Handlers/Land/LeftClick")]
    public  class LandLeftHandler : LandInputHandler
    {
        public override void Execute(Land land)
        {
            land.isActive = !land.isActive;

            //Not sure that this belongs here.  Need a way to instantiate the active status so display can monitor it.
            land.GetComponent<LandDisplay>().UpdateIncome();  
        }
    }
}