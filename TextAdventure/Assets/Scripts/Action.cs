using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    public abstract class Action : ScriptableObject
    {
        public string keyword;

        public abstract void RespondToInput(GameController controller, string noun);
    }
}
