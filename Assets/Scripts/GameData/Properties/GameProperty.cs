using UnityEngine;
using System.Collections;


namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Brume/Reference/Property")]
    public class GameProperty : ScriptableObject 
    {
        public enum ActionUse { EndTurn, MenuOption, LeftClick, OnSpawn }

        public ActionUse actionUse;
        public GameAction gameAction;
        bool isDisplayed;  //This is purely to make filtering easier.  Hardcoding is still necessary to create the display.
        
    }
}