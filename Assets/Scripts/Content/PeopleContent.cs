using UnityEngine;
using System.Collections.Generic;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Content/People")]
    public class PeopleContent : ScriptableObject
    {
        public List<HeroContent> allPeople;

        public HeroContent RandomHero()
        {
            if (allPeople.Count > 0)
            {
                HeroContent heroValue = allPeople[Random.Range(0, allPeople.Count)];
                allPeople.Remove(heroValue);

                return heroValue;
            }
            return null;
        }

    }
}
