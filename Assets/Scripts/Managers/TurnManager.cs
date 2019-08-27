using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    public class TurnManager : MonoBehaviour
    {
        [SerializeField] BoardReference gdBoard;

        public void EndTurn()
        {
            gdBoard.value.turnCounter.value++;
            FindObjectOfType<LandManager>().CreateLand();
        }
    }
}