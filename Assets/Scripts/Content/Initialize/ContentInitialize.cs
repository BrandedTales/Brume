using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu(menuName = "Brume/Content/Initialize/Default")]
    public class ContentInitialize : ScriptableObject
    {
        public int turnValue = 0;

        public List<GameAction> gameSetupActions;

        public List<HeroContent> heroList;
        public HeroIndex heroIndex;

        public List<LandContent> landList;
        public LandIndex landIndex;

        public LandList realTimeLandList;

        public void InitializeGame()
        {
            ResetIndices();
            RunActions();
            RunTimeData();

        }

        private void RunTimeData()
        {
            realTimeLandList.Items.Clear();  //Ultimately could be changed to reflect whatever the current game state is...
        }

        private void ResetIndices()
        {
            heroIndex.heroContentList.Clear();
            foreach (HeroContent hc in heroList)
            {
                heroIndex.heroContentList.Add(hc);
            }

            landIndex.landContentList.Clear();
            foreach (LandContent lc in landList)
            {
                landIndex.landContentList.Add(lc);
            }

        }

        private void RunActions()
        {
            GameData data = new GameData(this);
            foreach (GameAction a in gameSetupActions)
            {
                a.Execute(data);
            }
        }
    }
}