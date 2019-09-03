using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace BT.Brume {
    public class TurnDisplay : MonoBehaviour
    {
        public IntVariable turnCounter;

        // Update is called once per frame
        void Update()
        {
            GetComponent<Text>().text = ("Turn: " + turnCounter.value.ToString());
        }
    }
}