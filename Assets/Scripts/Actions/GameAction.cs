using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public abstract class GameAction : ScriptableObject
    {
        public abstract void Execute(GameData data);
    }
}