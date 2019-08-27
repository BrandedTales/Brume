using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Properties/FlavorVariable")]
    public class FlavorVariable : ScriptableObject
    {
        [TextArea(5, 10)] public string value;
    }
}