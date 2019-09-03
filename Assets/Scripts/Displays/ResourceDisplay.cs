using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BT.Brume
{
    public class ResourceDisplay : MonoBehaviour
    {

        public ResourcesReference resourceReference;
        public GameObject resourceDisplayPrefab;

        
        void Start()
        {
            foreach (ResourceVariable rv in resourceReference.resources)
            {
                AddResourceToPanel(rv);    
            }
            
        }
        // Update is called once per frame
        private void Update()
        {
            foreach (ResourceVariable rv in resourceReference.resources)
            {
                foreach (Transform child in transform)
                {
                    if (child.gameObject.name == rv.name)
                    {
                        RefreshResourceValue(child.gameObject, rv);
                        continue;
                    }
                }
            }
        }

        private void AddResourceToPanel(ResourceVariable resourceVariable)
        {
            GameObject resourceObject = GameObject.Instantiate(resourceDisplayPrefab, this.transform);
            resourceObject.name = resourceVariable.name;
            resourceObject.GetComponentInChildren<Image>().sprite = resourceVariable.sprite;
            resourceObject.GetComponentInChildren<Text>().text = resourceVariable.value.ToString();
        }

        private void RefreshResourceValue(GameObject resourceDisplay, ResourceVariable resourceVariable)
        {
            resourceDisplay.GetComponentInChildren<Text>().text = resourceVariable.value.ToString();
        }
    }
}