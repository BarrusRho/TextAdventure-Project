using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextAdventure
{    
    public class Connection : MonoBehaviour
    {
        public string connectionName;

        [TextArea]
        public string description;
        public Location location;
        public bool isConnectionEnabled;
    }
}
