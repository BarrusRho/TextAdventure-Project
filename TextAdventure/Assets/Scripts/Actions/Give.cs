using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    [CreateAssetMenu(menuName = "Actions/Give")]
    public class Give : Action
    {
        public override void RespondToInput(GameController controller, string noun)
        {
            if (controller.player.HasItemByName(noun))
            {
                if (GiveToItem(controller, controller.player.currentLocation.items, noun) == true)
                {
                    return;
                }
                controller.currentText.text = $"Nothing takes the {noun!}";
                return;
            }
            controller.currentText.text = $"You do not have {noun} to give";
        }

        private bool GiveToItem(GameController controller, List<Item> items, string noun)
        {
            {
                foreach (Item item in items)
                {
                    if (item.isItemEnabled == true)
                    {
                        if (controller.player.CanGiveToItem(controller, item))
                        {
                            if (item.InteractWith(controller, "give", noun))
                            {
                                return true;
                            }
                        }
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
