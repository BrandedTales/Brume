using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Content/Hero")]
    public class HeroContent : ScriptableObject
    {
        public ArtworkVariable artwork;
        public FlavorVariable flavor;
    }
}