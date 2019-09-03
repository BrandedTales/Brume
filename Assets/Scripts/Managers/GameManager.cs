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
            foreach (GameAction a in endTurnActions)
            {
                a.Execute(null);
            }
        }
    }
}
