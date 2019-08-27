using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Properties/BoardReference")]
    public class BoardReference : ScriptableObject
    {
        public GameData_Board value;
    }
}