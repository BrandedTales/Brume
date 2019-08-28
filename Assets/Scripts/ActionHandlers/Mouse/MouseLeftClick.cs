using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BT.Brume
{
    public class MouseLeftClick : MouseAction, IPointerClickHandler
    {
        

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                
            }
        }
    }
}