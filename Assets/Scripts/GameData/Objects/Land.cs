using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/GameData/Land")]
    public class Land : Piece
    {
        public struct Income
        {
            public ResourceVariable rv;
            public int count;
        }

        public bool isRevealed;

        public List<Income> incomeList;

        public void InitializePiece(LandContent lc)
        {
            cardPortrait = lc.cardPortrait;
            name = lc.name;
            flavor = lc.flavor;
            gameProperties = lc.gameProperties;

        }

        public void PopulateIncomeList(ResourcesReference rr)
        {
            incomeList = new List<Income>();

            foreach (ResourceVariable r in rr.resources)
            {
                Income i = new Income
                {
                    rv = r,
                    count = 0
                };
                incomeList.Add(i);
            }

            foreach (GameProperty gp in gameProperties)
            {
                if (gp.gameAction is ActionAdjustResources)
                {
                    ActionAdjustResources aar = gp.gameAction as ActionAdjustResources;
                    for (int i=0;i<incomeList.Count;i++)
                    {

                        if (incomeList[i].rv.name == aar.resourceVariable.name)
                        {
                            Income updatedIncome = incomeList[i];
                            updatedIncome.count += aar.adjustmentValue;
                            incomeList[i] = updatedIncome;
                            
                        }
                    }
                }
            }

        }

    }
}