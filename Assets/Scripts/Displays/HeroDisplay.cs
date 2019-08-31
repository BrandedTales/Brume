using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace BT.Brume
{
    public class HeroDisplay : MonoBehaviour
    {

        Hero hero;


        public void Start()
        {
            hero = GetComponent<Hero>();
        }

        public void GenerateDisplay()
        {
            UpdateArtwork();
            UpdateCardName();

        }


        public void UpdateArtwork()
        {
            if (hero.isDeployed)
                GetComponentInChildren<Image>().sprite = hero.artwork.value;

        }

        public void UpdateCardName()
        {
            if (hero.isDeployed)
                GetComponentInChildren<Text>().text = hero.name;
            else
                GetComponentInChildren<Text>().text = "";

        }
    }
}