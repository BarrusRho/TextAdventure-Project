using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    public class Location : MonoBehaviour
    {
        public string locationName;

        [TextArea]
        public string description;
        public Connection[] connections;
        public List<Item> items = new List<Item>();

        public string GetConnectionsText()
        {
            string result = $"";

            foreach (Connection connection in connections)
            {
                if (connection.isConnectionEnabled == true)
                {
                    result += $"{connection.description}\n";
                }
            }
            return result;
        }

        public Connection GetConnection(string connectionNoun)
        {
            foreach (Connection connection in connections)
            {
                if (connection.connectionName.ToLower() == connectionNoun.ToLower())
                {
                    return connection;
                }
            }
            return null;
        }

        public string GetItemsText()
        {
            if (items.Count == 0)
            {
                return $"";
            }
            var result = $"You see ";
            bool first = true;
            foreach (Item item in items)
            {
                if (item.isItemEnabled == true)
                {
                    if (first == false)
                    {
                        result += $" and ";
                    }
                    result += $"{item.itemDescription}";
                    first = false;
                }
            }
            result += $"\n";
            return result;
        }
    }
}
