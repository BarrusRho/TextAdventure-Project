using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    [CreateAssetMenu(menuName = "Actions/Help")]
    public class Help : Action
    {
        public override void RespondToInput(GameController controller, string verb)
        {
            controller.currentText.text = $"Type a Verb followed by a Noun (e.g. \"Go North\")";
            controller.currentText.text += $"\nAllowed verbs: \nGo, Examine, Get, Use, Inventory, TalkTo, Say, Help";
        }
    }

}
