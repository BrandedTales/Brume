using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using System;

namespace BT.Brume
{
    public class CardInstance : MonoBehaviour
    {
        public Piece pieceDetails;

        public GameAction leftClick;
        public GameAction rightClick;
        public GameAction endDrag;

        public bool isDraggable;

        public void OnDrag(BaseEventData eventData)
        {
            PointerEventData pointerEventData = eventData as PointerEventData;

            if (isDraggable)
            {
                transform.position = pointerEventData.position;
            }
        }

        public void OnEndDrag(BaseEventData eventData)
        {
            if (isDraggable)
            {
                PointerEventData pointerEventData = eventData as PointerEventData;

                GameData currentData = new GameData(pieceDetails);
                CardInstance dropLocation = null;

                if (CheckOverLand(out dropLocation))
                {
                    currentData.cardOver = dropLocation;
                    endDrag.Execute(currentData);
                    Destroy(this.gameObject);
                }
            }
        }

        private bool CheckOverLand(out CardInstance newLoc)
        {
            PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
            pointerEventData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerEventData, results);
            Debug.Log(results.Count);
            foreach (RaycastResult rr in results)
            {
                Debug.Log(rr.gameObject.transform.parent.gameObject.name);
                if (rr.gameObject.transform.parent.gameObject.GetComponent<CardInstance>().pieceDetails is Land)
                {
                    newLoc = rr.gameObject.transform.parent.GetComponent<CardInstance>();
                    return true;
                }         
            }
            newLoc = null;
            return false;
        }

        public void OnPointerUp(BaseEventData eventData)
        {
            PointerEventData pEventData = eventData as PointerEventData;
            GameData currentData = new GameData(pieceDetails);

            if ((pEventData.button == PointerEventData.InputButton.Left)&&(!pEventData.dragging))
            {
                leftClick.Execute(currentData);
            }
            if((pEventData.button == PointerEventData.InputButton.Right)&&(!pEventData.dragging))
            {
                rightClick.Execute(currentData);
            }
        }

    }
}