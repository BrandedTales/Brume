using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


namespace BT.Brume
{
    public class NotesInstance : MonoBehaviour
    {
        public Piece pieceDetails;

        public void CloseWindow()
        {
            Destroy(gameObject);
        }

    }
}