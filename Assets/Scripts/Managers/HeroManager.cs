using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace BT.Brume
{
    public class HeroManager : MonoBehaviour
    {
        public List<HeroAction> actions;
        [SerializeField] PeopleContent people;
        [SerializeField] Hero heroPrefab;

        public void SpawnHero()
        {

            foreach (HeroAction ha in actions)
            {
                if (ha is HA_SpawnHero)
                {
                    Hero newHero = Instantiate(heroPrefab);
                    ha.Invoke(newHero);
                }
            }
        }
    }
}