using UnityEngine;

namespace LevelSaveSystem.SelectionUI
{
    public class LevelSelectionUI : MonoBehaviour
    {
        [SerializeField] private string firstLevelName;

        [Space]
        [SerializeField] private LevelButton levelButtonPrefab;
        [SerializeField] private Transform levelButtonsRoute;

        [Space]
        [SerializeField] private LevelStartConfirmationTab levelStartConfirmationTab;

        public void ShowAvailableLevels(string[] levelNames)
        {
            CreateLevelButton(firstLevelName);

            foreach (string levelName in levelNames)
            {
                CreateLevelButton(levelName);
            }

            void CreateLevelButton(string levelName)
            {
                LevelButton levelButton = Instantiate(levelButtonPrefab, levelButtonsRoute);
                levelButton.Setup(levelName);
                levelButton.OnButtonClicked += () => levelStartConfirmationTab.Open(levelName);
            }
        }

    }
}
