using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    public class Player : MonoBehaviour
    {
        public Location currentLocation;
        public List<Item> inventory = new List<Item>();

        public bool CanChangeLocation(GameController controller, string connectionNoun)
        {
            Connection connection = currentLocation.GetConnection(connectionNoun);
            if (connection != null)
            {
                if (connection.isConnectionEnabled == true)
                {
                    currentLocation = connection.location;
                    return true;
                }
            }
            return false;
        }

        internal bool CanUseItem(GameController controller, Item item)
        {
            if (item.targetItem == null)
            {
                return true;
            }
            if (HasItem(item) == true)
            {
                return true;
            }
            if (currentLocation.HasItem(item) == true)
            {
                return true;
            }

            return false;
        }

        private bool HasItem(Item itemToCheck)
        {
            foreach (Item item in inventory)
            {
                if (item == itemToCheck)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
