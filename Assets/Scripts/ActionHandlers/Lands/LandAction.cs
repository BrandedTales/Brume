using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public abstract class LandAction : ScriptableObject
    {
    
        public abstract void Invoke(Land curLand);
    }
}
