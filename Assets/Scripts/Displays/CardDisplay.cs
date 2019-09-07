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
        public GameObject resourceIcon;
        public ResourcesReference rr;  //I hate having to associate this object and pass it!


        // Start is called before the first frame update
        void Start()
        {
            myCard = GetComponent<CardInstance>();

        }

        // Update is called once per frame
        void Update()
        {
            BasicDisplay();
            LandIncomeDisplay();  //OPTIMIZE:  This needs to be refactored to not run every update.  While great for dynamic income, it's a ton of effort for something that is effectively static.
        }

        private void BasicDisplay()
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

        private void LandIncomeDisplay()
        {
            if ((myCard.pieceDetails is Land)&&(myCard.pieceDetails.isActive))
            {

                //Clear existing icons
                foreach (Transform child in this.transform.Find("CardResourcePanel").transform)
                {
                    GameObject.Destroy(child.gameObject);
                }

                Land temp = myCard.pieceDetails as Land;
                temp.PopulateIncomeList(rr);
                foreach (Land.Income li in temp.incomeList)
                {
                    if (li.count != 0)
                    {
                        float sign = Mathf.Sign(li.count);
                        for (int j=0;j<Mathf.Abs(li.count);j++)
                        {
                            GameObject incomeIcon = Instantiate(resourceIcon, this.transform.Find("CardResourcePanel").transform);
                            incomeIcon.GetComponentInChildren<Image>().sprite = li.rv.sprite;
                            if (sign < 0) incomeIcon.GetComponentInChildren<Image>().color = Color.red;
                        }

                    }
                }
            }
        }

        private void PropertyDisplay()
        {
            foreach (GameProperty gp in myCard.pieceDetails.gameProperties)
            {
                if (gp.displayPanel != null)
                {
                    GameObject.Find(gp.displayPanel);
                }
            }
        }

    }
}