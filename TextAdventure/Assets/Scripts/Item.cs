using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    public class Item : MonoBehaviour
    {
        public string itemName;

        [TextArea]
        public string itemDescription;
        public bool canPlayerTakeItem;
        public bool isItemEnabled = true;        
        public Item targetItem = null;
        public Interaction[] interactions;


        public bool InteractWith(GameController controller, string actionKeyword)
        {
            foreach (Interaction interaction in interactions)
            {
                if (interaction.action.keyword == actionKeyword)
                {
                    foreach (Item disableItem in interaction.itemsToDisable)
                    {
                        disableItem.isItemEnabled = false;
                    }
                    foreach (Item enableItem in interaction.itemsToEnable)
                    {
                        enableItem.isItemEnabled = true;
                    }

                    foreach (Connection disableConnection in interaction.connectionsToDisable)
                    {
                        disableConnection.isConnectionEnabled = false;
                    }
                    foreach (Connection enableConnection in interaction.connectionsToEnable)
                    {
                        enableConnection.isConnectionEnabled = true;
                    }

                    controller.currentText.text = $"{interaction.response}";
                    controller.DisplayLocation(true);

                    return true;
                }
            }
            return false;
        }
    }
}
