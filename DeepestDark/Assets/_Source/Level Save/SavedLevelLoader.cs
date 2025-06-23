using LevelSaveSystem.SelectionUI;
using System.Collections.Generic;
using UnityEngine;

namespace LevelSaveSystem
{
    public class SavedLevelLoader : MonoBehaviour
    {
        [SerializeField] private SavableLevelsListSO savableLevelsList;
        [SerializeField] private LevelSelectionUI levelSelectionUI;

        private void Start()
        {
            List<string> savedLevels = new();

            foreach(string levelName in savableLevelsList.SavableLevels)
            {
                if (PlayerPrefs.GetInt(levelName) != 0)
                {
                    savedLevels.Add(levelName);
                }
            }

            levelSelectionUI.ShowAvailableLevels(savedLevels.ToArray());
        }
    }
}