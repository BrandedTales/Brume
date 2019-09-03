using UnityEngine;
using System.Collections.Generic;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Content/Hero")]
    public class HeroContent : ScriptableObject
    {
        public StringVariable flavor;
        public SpriteVariable cardPortrait;
        public SpriteVariable tokenArt;

        public List<GameProperty> gameProperties;


    }
}