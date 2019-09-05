using UnityEngine;
using System.Collections.Generic;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Content/Land")]
    public class LandContent : ScriptableObject
    {
        public StringVariable flavor;
        public SpriteVariable cardPortrait;
        public bool isUnique;
        
        public List<GameProperty> gameProperties;


    }
}