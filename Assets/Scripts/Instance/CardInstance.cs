using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


namespace BT.Brume
{
    public class CardInstance : MonoBehaviour
    {
        public Piece pieceDetails;

        public GameAction leftClick;

        public void OnPointerUp(BaseEventData eventData)
        {
            PointerEventData pEventData = eventData as PointerEventData;
            GameData currentData = new GameData(pieceDetails);

            if (pEventData.button == PointerEventData.InputButton.Left)
            {
                leftClick.Execute(currentData);
            }
        }

    }
}