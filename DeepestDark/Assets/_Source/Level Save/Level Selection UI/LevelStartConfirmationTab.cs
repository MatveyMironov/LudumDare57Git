using ClosableUISystem.Implementations.MB;
using SceneLoaderSystem.Implementations.MB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LevelSaveSystem.SelectionUI
{
    public class LevelStartConfirmationTab : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI questionText;

        [Space]
        [SerializeField] private AMBClosableUI closableUI;

        [Space]
        [SerializeField] private AMBSceneLoader sceneLoader;

        [Space]
        [SerializeField] private Button yesButton;
        [SerializeField] private Button noButton;

        private string _levelName = null;

        private void Start()
        {
            yesButton.onClick.AddListener(StartLevel);
            noButton.onClick.AddListener(Close);
        }

        public void Open(string levelName)
        {
            _levelName = levelName;

            questionText.text = $"Start {levelName}?";

            closableUI.Open();

            Debug.Log(yesButton.onClick.ToString());
        }

        public void Close()
        {
            _levelName = null;

            questionText.text = "";

            closableUI.Close();
        }

        private void StartLevel()
        {
            if (_levelName == null)
                return;

            sceneLoader.LoadScene(_levelName);
        }
    }
}