using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public class TurnManager : MonoBehaviour
    {
        [SerializeField] BoardReference gdBoard;
        [SerializeField] GameData_LandList gdLandList;
        [SerializeField] GameData_Resources gdResources;

        public void EndTurn()
        {
            gdBoard.value.turnCounter.value++;
            FindObjectOfType<LandManager>().CreateLand();
            FindObjectOfType<HeroManager>().SpawnHero();
            GenerateRevenue();
        }

        public void GenerateRevenue()
        {     
            foreach (Land land in gdLandList.Items)
            {
                if (land.isActive)
                {
                    for (int i = 0; i < land.income.Count; i++)
                    {
                        land.income[i].resource.value += (int)land.income[i].income;
                    }
                }
            }
        }
    }
}