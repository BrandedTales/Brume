using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Action/Open Notes Page")]
    public class OpenNotesPageAction : GameAction
    {

        public NotesInstance notesPrefab;

        public override void Execute(GameData data)
        {
            NotesInstance newMenu = Instantiate(notesPrefab);
            newMenu.name = data.currentPiece.name;
            newMenu.GetComponent<NotesInstance>().pieceDetails = data.currentPiece;

        }
    }
}