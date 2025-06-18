using ClosableUISystem;
using InputActionsManagerSystem;
using LevelSaveSystem;
using System;
using UnityEngine;

namespace GameSystem.GameWin
{
    public class GameWinController
    {
        private readonly IClosableUI _gameWinMenu;
        private readonly IInputActionsManager _inputActionsManager;
        private readonly LevelSaver _levelSaver;

        public GameWinController(IClosableUI gameWinMenu, IInputActionsManager inputActionsManager, LevelSaver levelSaver)
        {
            _gameWinMenu = gameWinMenu ?? throw new ArgumentNullException(nameof(gameWinMenu));
            _inputActionsManager = inputActionsManager ?? throw new ArgumentNullException(nameof(inputActionsManager));
            _levelSaver = levelSaver != null ? levelSaver : throw new ArgumentNullException(nameof(levelSaver));
        }

        public event Action OnGameWon;

        public void WinGame()
        {
            Time.timeScale = 0f;

            _inputActionsManager.DisableMovementInput();
            _inputActionsManager.DisableFlashlightInput();
            _inputActionsManager.DisableInteractionInput();
            _inputActionsManager.DisablePauseInput();
            _inputActionsManager.DisableDecoyInput();

            _levelSaver.SaveLevel();

            _gameWinMenu.Open();

            OnGameWon?.Invoke();
        }
    }
}
