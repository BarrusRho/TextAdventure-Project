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
        public Action[] actions;

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

        public void TextEntered()
        {
            Debug.Log($"Text entered");
            LogCurrentText();
            ProcessInput(textEntryField.text);
            textEntryField.text = $"";
            textEntryField.ActivateInputField();

        }

        public void LogCurrentText()
        {
            historyText.text += $"\n\n";
            historyText.text += $"{currentText.text}";
            historyText.text += $"\n\n";
            historyText.text += $"{textEntryField.text}";
        }

        public void ProcessInput(string input)
        {
            input = input.ToLower();
            char[] delimiter = { ' ' };
            string[] separatedWords = input.Split(delimiter);

            foreach (Action action in actions)
            {
                if (action.keyword.ToLower() == separatedWords[0])
                {
                    if (separatedWords.Length > 1)
                    {
                        action.RespondToInput(this, separatedWords[1]);
                    }
                    else
                    {
                        action.RespondToInput(this, "");
                    }
                    return;
                }
            }
            currentText.text = $"Nothing happens! Having trouble? Type Help";
        }
    }
}
