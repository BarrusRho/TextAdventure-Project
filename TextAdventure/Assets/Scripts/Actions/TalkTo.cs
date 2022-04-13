using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    [CreateAssetMenu(menuName = "Actions/Say")]
    public class TalkTo : Action
    {
        public override void RespondToInput(GameController controller, string noun)
        {
            if (TalkToItem(controller, controller.player.currentLocation.items, noun) == true)
            {
                return;
            }
            controller.currentText.text = $"There is no {noun} here!";
        }

        private bool TalkToItem(GameController controller, List<Item> items, string noun)
        {
            {
                foreach (Item item in items)
                {
                    if (item.itemName == noun && item.isItemEnabled == true)
                    {
                        if (controller.player.CanTalkToItem(controller, item))
                        {
                            if (item.InteractWith(controller, "talkto"))
                            {
                                return true;
                            }
                        }
                        controller.currentText.text = $"The {noun} does not respond to you.";
                        return true;
                    }
                }
                return false;
            }
        }
    }
}