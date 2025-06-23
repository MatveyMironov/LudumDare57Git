using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LevelSaveSystem.SelectionUI
{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI levelNameText;
        [SerializeField] private Button button;

        public event Action OnButtonClicked;

        private void Start()
        {
            button.onClick.AddListener(InvokeEvent);
        }

        public void Setup(string levelName)
        {
            levelNameText.text = levelName;
        }

        private void InvokeEvent()
        {
            OnButtonClicked?.Invoke();
        }
    }
}