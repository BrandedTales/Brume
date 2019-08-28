using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public abstract class LandInputHandler : ScriptableObject
    {
        public abstract void Execute(Land land);
    }
}