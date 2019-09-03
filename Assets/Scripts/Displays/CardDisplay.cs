using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BT.Brume
{
    public class CardDisplay : MonoBehaviour
    {
        CardInstance myHero;

        // Start is called before the first frame update
        void Start()
        {
            myHero = GetComponent<CardInstance>();
        }

        // Update is called once per frame
        void Update()
        {
            GetComponentInChildren<Image>().sprite = myHero.pieceDetails.cardPortrait.value;
            GetComponentInChildren<Text>().text = myHero.name;
        }
    }
}