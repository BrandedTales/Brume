using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/GameData/Land")]
    public class GameData_Land : ScriptableObject
    {
        public ArtworkVariable artwork;
        public FlavorVariable flavor;


    }
}