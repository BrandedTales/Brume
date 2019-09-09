using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;


namespace BT.Brume
{
    public class TokenInstance : MonoBehaviour
    {
        public Piece pieceDetails;

        public GameAction leftClick;
        public GameAction rightClick;

        public bool isDraggable;

        public void OnPointerUp(BaseEventData eventData)
        {
            PointerEventData pEventData = eventData as PointerEventData;
            GameData currentData = new GameData(pieceDetails);

            if ((pEventData.button == PointerEventData.InputButton.Left) && (!pEventData.dragging))
            {
                leftClick.Execute(currentData);
            }
            if ((pEventData.button == PointerEventData.InputButton.Right) && (!pEventData.dragging))
            {
                //rightClick.Execute(currentData);
            }
        }
    }
}