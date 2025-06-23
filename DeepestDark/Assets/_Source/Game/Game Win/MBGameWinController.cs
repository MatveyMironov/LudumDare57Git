using ClosableUISystem.Implementations.MB;
using InputActionsManagerSystem.Implementations.MB;
using LevelSaveSystem;
using System;
using UnityEngine;

namespace GameSystem.GameWin
{
    public class MBGameWinController : MonoBehaviour, IGameWinController
    {
        [SerializeField] private AMBClosableUI gameWinMenu;
        [SerializeField] private AMBInputActionsManager inputActionsManager;
        [SerializeField] private LevelSaver levelSaver;

        private GameWinController _gameWinController;

        private GameWinController GameWinController
        {
            get
            {
                _gameWinController ??= new(gameWinMenu, inputActionsManager, levelSaver);

                return _gameWinController;
            }
        }

        public event Action OnGameWon { add { GameWinController.OnGameWon += value; } remove { GameWinController.OnGameWon -= value; } }

        public void WinGame()
        {
            GameWinController.WinGame();
        }
    }
}
