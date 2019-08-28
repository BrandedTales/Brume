using UnityEngine;
using System.Collections;


namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Properties/Income")]
    public class Income : ScriptableObject
    {
        public Resource resource;
        public float income;
    }
}
