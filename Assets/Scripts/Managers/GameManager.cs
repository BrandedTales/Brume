using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public class GameManager : MonoBehaviour
    {
        public List<GameAction> gameSetupActions;
        public List<GameAction> endTurnActions;
       
        public ContentInitialize newGame;

        // Start is called before the first frame update
        void Start()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            GameData data = new GameData(newGame);
            foreach (GameAction a in gameSetupActions)
            {
                a.Execute(data);
            }

        }

        public void NextTurn()
        {
            foreach (GameAction a in endTurnActions)
            {
                a.Execute(null);
            }
        }
    }
}
