using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Handlers/Hero/Drag")]
    public  class HeroDragHandler : HeroInputHandler
    {
        public override void Execute(Hero hero, PointerEventData eventData)
        {
            Vector2 move = new Vector2(Input.mousePosition.x - hero.transform.position.x, Input.mousePosition.y - hero.transform.position.y);
            hero.transform.Translate(move);
        }     

    }
}