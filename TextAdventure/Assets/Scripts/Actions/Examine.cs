using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    [CreateAssetMenu(menuName = "Actions/Examine")]
    public class Examine : Action
    {
        public override void RespondToInput(GameController controller, string noun)
        {
            if (CheckItems(controller, controller.player.currentLocation.items, noun) == true)
            {
                return;
            }
            if (CheckItems(controller, controller.player.inventory, noun) == true)
            {
                return;
            }

            controller.currentText.text = $"You cannot see a {noun}";
        }

        private bool CheckItems(GameController controller, List<Item> items, string noun)
        {
            foreach (Item item in items)
            {
                if (item.itemName == noun)
                {
                    if (item.InteractWith(controller, "examine"))
                    {
                        return true;
                    }
                    controller.currentText.text = $"You see {item.itemDescription}";
                    return true;
                }
            }
            return false;
        }
    }
}
