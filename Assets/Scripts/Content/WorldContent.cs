using UnityEngine;
using System.Collections.Generic;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Content/World")]
    public class WorldContent : ScriptableObject
    {
        public LandContent[] allLands;

        public LandContent RandomLand()
        {
            return allLands[Random.Range(0, allLands.Length)];
        }

    }
}