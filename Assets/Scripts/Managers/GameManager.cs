using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public class GameManager : MonoBehaviour
    {

        public List<GameAction> endTurnActions;
        public ContentInitialize newGame;

        public LandList landList;

        // Start is called before the first frame update
        void Start()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            newGame.InitializeGame();
        }

        public void NextTurn()
        {
            DirectActions();
            LandActions();

        }

        private void LandActions()
        {
            if (landList == null) return;
            for (int i=0;i<landList.Items.Count;i++)
            {
                for (int j=0;j<landList.Items[i].gameProperties.Count;j++)
                {
                    GameProperty gp = landList.Items[i].gameProperties[j];

                    if ((gp.actionUse == GameProperty.ActionUse.EndTurn)&&(landList.Items[i].isActive))
                    {
                        //Currently passing in Null.  Will eventually need to build game-data to send based on what is on this land, etc
                        gp.gameAction.Execute(null);
                    }
                }
            }
        }

        private void DirectActions()
        {
            foreach (GameAction a in endTurnActions)
            {
                a.Execute(null);
            }
        }
    }
}
