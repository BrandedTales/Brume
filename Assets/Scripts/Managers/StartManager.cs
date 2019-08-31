using UnityEngine;
using System.Collections;
using System;

namespace BT.Brume
{
    public class StartManager : MonoBehaviour
    {

        public InitContent iContent;
        public PeopleContent thePeople;
        public WorldContent theWorld;
        public GameData_Resources gameResources;

        // Use this for initialization
        void Start()
        {
            ClearGameStates();
            ClearResources();
            SetDefaultContent();
        }

        private void ClearResources()
        {
            for (int i=0;i<gameResources.resources.Length;i++)
            {
                gameResources.resources[i].value = 5;
            }
        }

        private void SetDefaultContent()
        {
            theWorld.allLands.Clear();
            for (int i=0;i<iContent.allLands.Length;i++)
            {
                theWorld.allLands.Add(iContent.allLands[i]);
            }

            thePeople.allPeople.Clear();
            for (int i=0;i<iContent.allPeople.Length;i++)
            {
                thePeople.allPeople.Add(iContent.allPeople[i]);
            }
        }

        private void ClearGameStates()
        {
            iContent.gdBoard.turnCounter.value = 0;
            iContent.gdHero.Items.Clear();
            iContent.gdLand.Items.Clear();
        }

    }
}