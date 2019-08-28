using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace BT.Brume
{
    public class LandDisplay : MonoBehaviour
    {
        Land land;
        [SerializeField] Sprite cardBack;
        [SerializeField] GameObject resourcePrefab;

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
            if (land.isActive)
                GetComponentInChildren<Image>().sprite = land.artwork.value;
            else
                GetComponentInChildren<Image>().sprite = cardBack;
        }

        public void UpdateCardName()
        {
            if (land.isActive)
                GetComponentInChildren<Text>().text = land.name;
            else
                GetComponentInChildren<Text>().text = "";
        }


        public void UpdateIncome()  
        {
            if (land.isActive)
            {
                //GameObject.Find("LandResourcePanel").SetActive(true);
                //Debug.Log("Total Income types: " + land.income.Count);
                foreach (Transform child in MyPanel())
                {
                    //Debug.Log(child.name+ " Deleted! " + GameObject.Find("LandResourcePanel").transform.childCount + " remaining objects.");
                    Destroy(child.gameObject);
                }

                for (int i = 0; i < land.income.Count; i++)
                {
                    float incomeAmount = Mathf.Abs(land.income[i].income);
                    bool incomeNegative = false;
                    if (Mathf.Sign(land.income[i].income)<0) incomeNegative = true;
                    //Debug.Log("Income amount is: " + incomeAmount + ", " + incomeNegative.ToString());

                    for (int j = 0; j < incomeAmount; j++)
                    {
                        GameObject newResource = Instantiate(resourcePrefab, MyPanel());
                        if (newResource == null)
                        {
                            //Debug.Log("Huh.  Didn't see that coming.");
                            return;
                        }
                        newResource.GetComponentInChildren<Image>().sprite = land.income[i].resource.artwork;
                        if (incomeNegative)
                            newResource.GetComponentInChildren<Image>().color = Color.red;
                    }
                }
            }
            else
            {
                foreach (Transform child in MyPanel())
                {
                    //Debug.Log(child.name + " Deleted! " + GameObject.Find("LandResourcePanel").transform.childCount + " remaining objects.");
                    Destroy(child.gameObject);
                }
            }
        }

        public Transform MyPanel()
        {
            foreach(GameObject g in GameObject.FindGameObjectsWithTag("LandResourcePanel"))
            {
                if (g.transform.parent == this.gameObject.transform) return g.transform;
               
            }
            return null;
        }

    }
}