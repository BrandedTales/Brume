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

        public CardInstance cardPrefab;

        public override void Execute(GameData data)
        {
            heroContent = heroIndex.RandomHero();
            if (heroContent != null)
            {
                CardInstance newCard = Instantiate(cardPrefab);
                newCard.transform.SetParent(GameObject.Find("HeroPanel").transform);  //Don't like this hard reference.
                newCard.name = heroContent.name;
                newCard.isDraggable = true;

                var hero = ScriptableObject.CreateInstance<Hero>();
                hero.InitializePiece(heroContent);
                hero.isActive = true;
                
                newCard.GetComponent<CardInstance>().pieceDetails = hero;
            }
        }
    }
}
