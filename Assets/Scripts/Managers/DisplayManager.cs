using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public class DisplayManager : MonoBehaviour
    {
        [SerializeField] BoardReference gdBoard;
        [SerializeField] GameData_LandList gdLandList;

        ResourceDisplay resourceDisplay;
        LabelDisplay labelDisplay;

        // Start is called before the first frame update
        void Start()
        {
            resourceDisplay = FindObjectOfType<ResourceDisplay>();
            labelDisplay = FindObjectOfType<LabelDisplay>();

            if (resourceDisplay != null) resourceDisplay.CreateResources();

            
        }

        // Update is called once per frame
        void Update()
        {
            if (labelDisplay != null) labelDisplay.UpdateTurnCounter();
            if (resourceDisplay != null) resourceDisplay.RefreshResources();
            if (gdLandList.Items.Count > 0) GenerateLands();
        }

        private void GenerateLands()
        {
            foreach (Land land in gdLandList.Items)
            {
                Debug.Log("Generating display!" + gdLandList.Items.Count);

                land.GetComponent<LandDisplay>().GenerateDisplay();
                land.GetComponent<LandDisplay>().UpdateIncome();
            }
        }

    }
}