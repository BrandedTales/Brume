using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Handlers/Hero/EndDrag")]
    public  class HeroEndDragHandler : HeroInputHandler
    {
        public override void Execute(Hero hero, PointerEventData eventData)
        {
            List<RaycastResult> objectsHit = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, objectsHit);

            foreach (RaycastResult rr in objectsHit)
            {
                if  (rr.gameObject.GetComponentInParent<Land>() != null)
                {
                    LandDrop(hero, rr.gameObject.GetComponentInParent<Land>());
                    break;
                }

            }
        }

        private void LandDrop(Hero hero, Land land)
        {
            LandManager.ConvertToToken(hero, land);
        }
    }
}