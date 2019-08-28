using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Content/Land")]
    public class LandContent : ScriptableObject
    {
        public ArtworkVariable artwork;
        public FlavorVariable flavor;

        public Income[] income;      
    }
}