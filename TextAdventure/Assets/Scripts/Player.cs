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
    }
}
