using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(fileName ="Resource", menuName = "Brume/Resource")]
    public class Resource : ScriptableObject
    {
        public Sprite artwork;
        public int value;
    }
}