using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public class TurnManager : MonoBehaviour
    {
        [SerializeField] GameData_Board gdBoard;

        public void EndTurn()
        {
            gdBoard.turnCounter.value++;
        }
    }
}