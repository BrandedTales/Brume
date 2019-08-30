using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public abstract class HeroAction : ScriptableObject
    {
    
        public abstract void Invoke(Hero curHero);
    }
}
