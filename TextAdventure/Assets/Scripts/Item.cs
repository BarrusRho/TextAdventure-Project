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
    }
}
