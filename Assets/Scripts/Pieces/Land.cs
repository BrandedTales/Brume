using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace BT.Brume
{
    public class Land : MonoBehaviour
    {
        public bool isActive;

        public ArtworkVariable artwork;
        public FlavorVariable flavor;
        public List<Income> income;

        public LandInputHandler leftClick;
        public LandInputHandler rightClick;

        public GameData_LandList landList;

        public void InitializeLand(LandContent newLand)
        {
            isActive = false;
            this.name = newLand.name;
            artwork = newLand.artwork;
            flavor = newLand.flavor;

            for (int i=0;i<newLand.income.Length;i++)
            {
                income.Add(newLand.income[i]);
            }


            landList.Add(this);
        }

        public void LandClick(BaseEventData eventData)
        {
            PointerEventData pointerData = eventData as PointerEventData;

            if (pointerData.button == PointerEventData.InputButton.Left) LeftClick();
            if (pointerData.button == PointerEventData.InputButton.Right) RightClick();
        }

        public void LeftClick()
        {
            leftClick.Execute(this);
        }

        private void RightClick()
        {
            rightClick.Execute(this);
        }

    }
}