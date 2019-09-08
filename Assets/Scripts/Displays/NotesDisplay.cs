using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BT.Brume
{
    public class NotesDisplay : MonoBehaviour
    {

        NotesInstance myNotes;

        public SpriteVariable cardBack;

        // Start is called before the first frame update
        void Start()
        {
            myNotes = GetComponent<NotesInstance>();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateFields();
        }

        private void UpdateFields()
        {
            Transform panel = transform.Find("Panel");

            //For future reference, this is done in this hacky-sloppy-backwards way because I couldn't debug why a cleaner way was 
            //throwing object reference issues; nothing would update.
            foreach (Transform child in panel)
            {
                if (child.gameObject.name == "Image")
                {
                    UpdateImage(child, myNotes.pieceDetails.isActive);
                }
                if (child.gameObject.name == "NameText")
                {
                    UpdateName(child, myNotes.pieceDetails.isActive);
                }
                if (child.gameObject.name == "FlavorText")
                {
                    UpdateFlavor(child, myNotes.pieceDetails.isActive);
                }
            }

        }

        private void UpdateFlavor(Transform child, bool isActive)
        {
            if (isActive)
                child.GetComponent<Text>().text = myNotes.pieceDetails.flavor.value;
            else
                child.GetComponent<Text>().text = "Immense opportunity awaits... You simply need to explore and discover it.";
        }

        private void UpdateName(Transform child, bool isActive)
        {
            if (isActive)
                child.GetComponent<Text>().text = myNotes.pieceDetails.name;
            else
                child.GetComponent<Text>().text = "Unknown Land";
        }

        private void UpdateImage(Transform child, bool isActive)
        {
            if (isActive)
            {
                child.GetComponent<Image>().sprite = myNotes.pieceDetails.cardPortrait.value;
            }
            else
            {
                child.GetComponent<Image>().sprite = cardBack.value;
            }
        }
    }
}