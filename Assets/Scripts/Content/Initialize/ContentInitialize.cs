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

        public void InitializeGame()
        {
            ResetIndices();
            RunActions();

        }

        private void ResetIndices()
        {
            heroIndex.heroContentList.Clear();
            foreach (HeroContent hc in heroList)
            {
                heroIndex.heroContentList.Add(hc);
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