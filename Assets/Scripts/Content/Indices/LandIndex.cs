using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Indices/Land Index")]
    public class LandIndex : ScriptableObject
    {
        public List<LandContent> landContentList;

        public LandContent RandomLand()
        {
            LandContent randomLand = null;

            if (landContentList.Count > 0)
            {
                randomLand = landContentList[Random.Range(0, landContentList.Count)];
                if (randomLand.isUnique) landContentList.Remove(randomLand);
            }

            return randomLand;
        }
    }
}