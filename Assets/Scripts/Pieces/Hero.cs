using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

namespace BT.Brume
{
    public class Hero : Piece
    {
        public GameData_HeroList heroList;

        public HeroLeftHandler leftClick;
        public HeroRightHandler rightClick;
        public HeroDragHandler heroDrag;
        public HeroEndDragHandler heroEndDrag;

        public void InitializeHero(HeroContent newHero)
        {
            isDeployed = true;
            this.name = newHero.name;
            artwork = newHero.artwork;
            flavor = newHero.flavor;

            heroList.Add(this);
        }

        public void HeroClick(BaseEventData eventData)
        {
            PointerEventData pointerData = eventData as PointerEventData;

            if (pointerData.button == PointerEventData.InputButton.Left) LeftClick(pointerData);
            if (pointerData.button == PointerEventData.InputButton.Right) RightClick(pointerData);
        }

        private void RightClick(PointerEventData eventData)
        {
            rightClick.Execute(this, eventData);
        }

        private void LeftClick(PointerEventData eventData)
        {
            leftClick.Execute(this, eventData);
        }

        public void HeroDrag(BaseEventData eventData)
        {
            PointerEventData pointerData = eventData as PointerEventData;
            heroDrag.Execute(this, pointerData);
        }

        public void HeroEndDrag(BaseEventData eventData)
        {
            PointerEventData pointerData = eventData as PointerEventData;
            heroEndDrag.Execute(this, pointerData);
        }
    }
}