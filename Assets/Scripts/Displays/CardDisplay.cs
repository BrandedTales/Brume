using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BT.Brume
{
    public class CardDisplay : MonoBehaviour
    {
        CardInstance myCard;
        public SpriteVariable cardBack;

        // Start is called before the first frame update
        void Start()
        {
            myCard = GetComponent<CardInstance>();
        }

        // Update is called once per frame
        void Update()
        {
            if (myCard.pieceDetails.isActive)
            {
                GetComponentInChildren<Image>().sprite = myCard.pieceDetails.cardPortrait.value;
                GetComponentInChildren<Text>().text = myCard.name;
            }
            else
            {
                GetComponentInChildren<Image>().sprite = cardBack.value;
            }
        }
    }
}