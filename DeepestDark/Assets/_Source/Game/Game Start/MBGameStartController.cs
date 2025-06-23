using ClosableUISystem.Implementations.MB;
using FlashlightSystem.Implementations.MB;
using InputActionsManagerSystem.Implementations.MB;
using OxygenConsumerSystem.Implementations.MB;
using OxygenTankSystem.Implementations.MB;
using System;
using UnityEngine;

namespace GameSystem.GameStart
{
    public class MBGameStartController : MonoBehaviour, IGameStartController
    {
        [SerializeField] private GameObject player;
        [SerializeField] private Transform startPoint;
        [SerializeField] private AMBClosableUI gameStartMenu;
        [SerializeField] private AMBOxygenTank oxygenTank;
        [SerializeField] private AMBOxygenConsumer oxygenConsumer;
        [SerializeField] private AMBFlashlight flashlight;
        [SerializeField] private AMBInputActionsManager inputActionsManager;

        [Space]
        [SerializeField] private GameStartConfiguration gameStartConfiguration;

        private GameStartController _gameStartController;

        private GameStartController GameStartController
        {
            get
            {
                _gameStartController ??= new(player, startPoint, gameStartMenu, oxygenTank, oxygenConsumer, flashlight, inputActionsManager, gameStartConfiguration);

                return _gameStartController;
            }
        }

        public event Action OnGameStarted { add { GameStartController.OnGameStarted += value; } remove { GameStartController.OnGameStarted -= value; } }

        public void StartGame()
        {
            GameStartController.StartGame();
        }
    }
}
