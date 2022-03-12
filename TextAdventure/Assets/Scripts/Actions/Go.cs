using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    [CreateAssetMenu(menuName = "Actions/Go")]
    public class Go : Action
    {
        public override void RespondToInput(GameController controller, string verb)
        {
            if (controller.player.CanChangeLocation(controller, verb) == true)
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
