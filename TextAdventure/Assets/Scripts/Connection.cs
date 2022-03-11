using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{
    [System.Serializable]
    public class Connection
    {
        public string connectionName;
        public string description;
        public Location location;
        public bool isConnectionEnabled;
    }
}
