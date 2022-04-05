using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    [CreateAssetMenu(menuName = "Actions/Get")]
    public class Get : Action
    {
        public override void RespondToInput(GameController controller, string noun)
        {
            foreach(Item item in controller.player.currentLocation.items)
            {
                if (item.isItemEnabled && item.itemName == noun)
                {
                    if (item.canPlayerTakeItem == true)
                    {
                        controller.player.inventory.Add(item);
                        controller.player.currentLocation.items.Remove(item);
                        controller.currentText.text = $"You take the {noun}";
                        return;
                    }
                }
            }
            controller.currentText.text = $"You cannot get that";
        }
    }
}
