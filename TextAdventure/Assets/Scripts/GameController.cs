using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TextAdventure
{
    public class GameController : MonoBehaviour
    {
        public Player player;
        public TMP_InputField textEntryField;
        public TMP_Text historyText;
        public TMP_Text currentText;

        [TextArea]
        public string introText;

        private void Start()
        {
            historyText.text = introText;
            DisplayLocation();
            textEntryField.ActivateInputField();
        }

        public void DisplayLocation()
        {
            string description = $"{player.currentLocation.description}\n";
            description += $"{player.currentLocation.GetConnectionsText()}";
            currentText.text = $"{description}";
        }
    }
}
