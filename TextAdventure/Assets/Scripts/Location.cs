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
    }
}
