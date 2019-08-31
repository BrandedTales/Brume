using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BT.Brume
{
    public abstract class HeroInputHandler : ScriptableObject
    {
        public abstract void Execute(Hero hero, PointerEventData eventData);
    }
}