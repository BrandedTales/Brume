using UnityEngine;
using System.Collections.Generic;


namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Reference/Resources")]
    public class ResourcesReference : ScriptableObject
    {
        public List<ResourceVariable> resources;
    }
}