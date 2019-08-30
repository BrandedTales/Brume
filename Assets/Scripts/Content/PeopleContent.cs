using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Content/People")]
    public class PeopleContent : ScriptableObject
    {
        public HeroContent[] allPeople;

        public HeroContent RandomHero()
        {
            return allPeople[Random.Range(0, allPeople.Length)];
        }

    }
}
