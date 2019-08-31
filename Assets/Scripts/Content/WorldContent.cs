using UnityEngine;
using System.Collections.Generic;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Content/World")]
    public class WorldContent : ScriptableObject
    {
        public List<LandContent> allLands;

        public LandContent RandomLand()
        {
            return allLands[Random.Range(0, allLands.Count)];
        }

    }
}