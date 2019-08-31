using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Handlers/Hero/LeftClick")]
    public  class HeroLeftHandler : HeroInputHandler
    {
        public override void Execute(Hero hero, PointerEventData eventData)
        {
            Debug.Log("Left Click hero!");
        }
    }
}