using UnityEngine;
using System.Collections;

namespace BT.Brume
{
    public class GameData 
    {
        //Populate with content I'd want to pass around.

        //Current turn.
        public int turnValue;

        public GameData(ContentInitialize ct)
        {
            turnValue = ct.turnValue;
        }
    }
}