using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName="Brume/Variable/Resource")]
    public class ResourceVariable : ScriptableObject
    {
        public Sprite sprite;
        public int value;
    }
}
