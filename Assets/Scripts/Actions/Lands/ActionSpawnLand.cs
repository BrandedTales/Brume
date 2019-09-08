using UnityEngine;
using System.Collections;
using System;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Action/Spawn Land")]
    public class ActionSpawnLand : GameAction
    {

        public LandIndex landIndex;
        LandContent landContent;
        public LandList landList;

        public CardInstance cardPrefab;

        public override void Execute(GameData data)
        {
            landContent = landIndex.RandomLand();
            if (landContent != null)
            {
                CardInstance newCard = Instantiate(cardPrefab);
                newCard.transform.SetParent(GameObject.Find("LandPanel").transform);  //Don't like this hard reference.
                newCard.name = landContent.name;
                newCard.isDraggable = false;

                var land = ScriptableObject.CreateInstance<Land>();
                land.isRevealed = false;
                land.isActive = false;
                land.InitializePiece(landContent);

                landList.Add(land);
                newCard.GetComponent<CardInstance>().pieceDetails = land;
            }
        }
    }
}
