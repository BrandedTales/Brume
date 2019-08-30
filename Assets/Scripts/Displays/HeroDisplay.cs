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
        [SerializeField] Sprite cardBack;

        public void Start()
        {
            hero = GetComponent<Hero>();
        }

        public void GenerateDisplay()
        {
            UpdateLabel();
            UpdateArtwork();
            UpdateCardName();

        }

        public void UpdateLabel()
        {
            GameObject label = null;

            foreach (GameObject go in GameObject.FindGameObjectsWithTag("LabelBack"))
            {
                if (go.transform.parent = transform)
                    label = go;
            }

            if (label != null)
                label.SetActive(!hero.isDeployed);
            Debug.Log("Setting label to " + (!hero.isDeployed).ToString());
                
        }

        public void UpdateArtwork()
        {
            if (hero.isDeployed)
                GetComponentInChildren<Image>().sprite = hero.artwork.value;
            else
                GetComponentInChildren<Image>().sprite = cardBack;
        }

        public void UpdateCardName()
        {
            if (hero.isDeployed)
                GetComponentInChildren<Text>().text = hero.name;
            else
                GetComponentInChildren<Text>().text = "";

            Debug.Log("Setting name to " + hero.name);
        }
    }
}