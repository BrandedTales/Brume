using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Content/Initialize")]
    public class InitContent : ScriptableObject
    {
        public HeroContent[] allPeople;
        public LandContent[] allLands;

        public GameData_Board gdBoard;
        public GameData_LandList gdLand;
        public GameData_HeroList gdHero;

    }
}