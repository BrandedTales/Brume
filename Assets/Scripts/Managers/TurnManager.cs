using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public class TurnManager : MonoBehaviour
    {
        [SerializeField] BoardReference gdBoard;
        [SerializeField] GameData_LandList gdLandList;

        public void EndTurn()
        {
            gdBoard.value.turnCounter.value++;
            FindObjectOfType<LandManager>().CreateLand();
        }

        public void GenerateRevenue()
        {
            foreach (Land land in gdLandList.Items)
            {

            }
        }
    }
}