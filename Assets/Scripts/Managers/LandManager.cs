using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace BT.Brume
{
    public class LandManager : MonoBehaviour
    {
        public List<LandAction> actions;
        [SerializeField] WorldContent world;
        [SerializeField] Land landPrefab;

        public void CreateLand()
        {
            
            foreach (LandAction la in actions)
            {
                if (la is LA_CreateLand)
                {
                    Land newLand = Instantiate(landPrefab);
                    la.Invoke(newLand);
                }
            }
        }
    }
}