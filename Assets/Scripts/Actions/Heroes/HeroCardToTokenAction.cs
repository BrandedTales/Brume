using UnityEngine;
using System.Collections;
using System;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Action/Hero To Token")]
    public class HeroToTokenAction : GameAction
    {
        Hero hero;

        public TokenInstance tokenPrefab;

        public override void Execute(GameData data)
        {
            hero = data.currentPiece as Hero;
            if (hero != null)
            {

                TokenInstance newToken = Instantiate(tokenPrefab);
                if (data.cardOver != null)
                    newToken.transform.SetParent(data.cardOver.transform);
                else
                    newToken.transform.SetParent(GameObject.Find("HeroPanel").transform);  //Don't like this hard reference.
                newToken.name = hero.name;
                newToken.isDraggable = true;
                newToken.transform.SetPositionAndRotation(new Vector3(newToken.transform.parent.transform.position.x, newToken.transform.parent.transform.position.y, newToken.transform.parent.transform.position.z), Quaternion.identity);

                newToken.GetComponent<TokenInstance>().pieceDetails = hero;
            }
        }

    }
}