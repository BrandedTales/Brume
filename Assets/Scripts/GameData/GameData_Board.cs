using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/GameData/Board")]
    public class GameData_Board : ScriptableObject
    {
        public FloatVariable turnCounter;
        public List<Land> landList;

        public void AddLand(Land newLand)
        {
            landList.Add(newLand);
        }
    }
}
