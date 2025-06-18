using System.Linq;
using UnityEngine;

namespace LevelSaveSystem
{
    public class LevelSaver : MonoBehaviour
    {
        [SerializeField] private SavableLevelsListSO savableLevelsList;
        [SerializeField] private string savedLevelName;

        public void SaveLevel()
        {
            if (savableLevelsList.SavableLevels.Contains(savedLevelName))
            {
                PlayerPrefs.SetInt(savedLevelName, 1);
            }
        }
    }
}