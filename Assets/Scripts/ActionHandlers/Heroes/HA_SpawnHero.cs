using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Actions/SpawnHero")]
    public class HA_SpawnHero : HeroAction
    {
        [SerializeField] BoardReference gdBoard;
        [SerializeField] PeopleContent people;

        public override void Invoke(Hero curHero)
        {
            curHero.InitializeHero(people.RandomHero());
            curHero.transform.SetParent(GameObject.FindGameObjectWithTag("HeroPanel").transform, false);

        }
    }
}