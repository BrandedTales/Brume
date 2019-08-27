using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace BT.Brume
{
    public class LandDisplay : MonoBehaviour
    {
        Land land;

        public void Start()
        {
            land = GetComponent<Land>();
        }

        public void GenerateDisplay()
        {
            UpdateArtwork();
            UpdateCardName();
        }


        public void UpdateArtwork()
        {
            GetComponentInChildren<Image>().sprite = land.artwork.value;
        }

        public void UpdateCardName()
        {
            GetComponentInChildren<Text>().text = land.name;
        }

    }
}