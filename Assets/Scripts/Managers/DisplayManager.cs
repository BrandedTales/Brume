using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public class DisplayManager : MonoBehaviour
    {
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
        }
    }
}