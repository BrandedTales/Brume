using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BT.Brume
{
    public class TokenDisplay : MonoBehaviour
    {

        TokenInstance myToken;

        // Start is called before the first frame update
        void Start()
        {
            myToken = GetComponent<TokenInstance>();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateSprite();
        }

        private void UpdateSprite()
        {
            GetComponentInChildren<Image>().sprite = myToken.pieceDetails.token.value;
        }
    }
}