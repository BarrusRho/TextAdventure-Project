using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    [CreateAssetMenu(menuName = "Actions/Go")]
    public class Go : Action
    {
        public override void RespondToInput(GameController controller, string noun)
        {
            if (controller.player.CanChangeLocation(controller, noun) == true)
            {
                controller.DisplayLocation();
            }
            else
            {
                controller.currentText.text = $"You cannot go that way";
            }
        }
    }
}
