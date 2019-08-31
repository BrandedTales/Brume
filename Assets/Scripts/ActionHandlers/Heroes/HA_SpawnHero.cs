using UnityEngine;
using System.Collections.Generic;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Actions/SpawnHero")]
    public class HA_SpawnHero : HeroAction
    {
        [SerializeField] BoardReference gdBoard;
        [SerializeField] PeopleContent people;

        public override void Invoke(Hero curHero)
        {
            HeroContent hero = people.RandomHero();
            if (hero != null)
            {
                curHero.InitializeHero(hero);
                curHero.transform.SetParent(GameObject.FindGameObjectWithTag("HeroPanel").transform, false);
            }
        }
    }
}