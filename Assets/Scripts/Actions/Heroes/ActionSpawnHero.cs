using UnityEngine;
using System.Collections;
using System;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Action/Spawn Hero")]
    public class ActionSpawnHero : GameAction
    {

        public HeroIndex heroIndex;
        HeroContent heroContent;

        public GameObject cardPrefab;

        public override void Execute(GameData data)
        {
            heroContent = heroIndex.RandomHero();
            if (heroContent != null)
            {
                GameObject newCard = Instantiate(cardPrefab);
                newCard.transform.SetParent(GameObject.Find("HeroPanel").transform);  //Don't like this hard reference.
                newCard.name = heroContent.name;

                var hero = ScriptableObject.CreateInstance<Hero>();
                hero.InitializePiece(heroContent);

                newCard.GetComponent<CardInstance>().pieceDetails = hero;
            }
        }
    }
}
