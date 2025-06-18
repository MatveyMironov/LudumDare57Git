using System.Collections;
using UnityEngine;

namespace LevelSaveSystem
{
    [CreateAssetMenu(fileName = "NewSavableLevelsListSO", menuName = "Savable Levels List")]
    public class SavableLevelsListSO : ScriptableObject
    {
        [field: SerializeField] public string[] SavableLevels { get; private set; } = new string[0];
    }
}