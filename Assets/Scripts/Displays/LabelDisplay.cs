using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BT.Brume
{
    public class LabelDisplay : MonoBehaviour
    {
        public Text turnCounterText;
        public BoardReference gdBoard;

        public void UpdateTurnCounter()
        {
            Debug.Log("Update turn counter.");
            turnCounterText.text = "Turn: " + gdBoard.value.turnCounter.value.ToString();
        }
    }
}