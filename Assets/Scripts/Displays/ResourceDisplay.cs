using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BT.Brume
{
    public class ResourceDisplay : MonoBehaviour
    {
        [SerializeField] GameData_Resources resources;
        [SerializeField] GameObject resourcePrefab;

        public void CreateResources()
        {
            foreach (Resource r in resources.resources)
            {
                GameObject newResource = Instantiate(resourcePrefab, GameObject.Find("ResourcePanel").transform);
                if (newResource == null)
                {
                    Debug.Log("Huh.  Didn't see that coming.");
                    return;
                }
                newResource.name = r.name;
                newResource.GetComponentInChildren<Image>().sprite = r.artwork;
                newResource.GetComponentInChildren<Text>().text = r.value.ToString();
            }
        }
        public void RefreshResources()
        {
            foreach (Resource r in resources.resources)
            {
                GameObject.Find(r.name).GetComponentInChildren<Text>().text = r.value.ToString();
            }
        }
    }
}