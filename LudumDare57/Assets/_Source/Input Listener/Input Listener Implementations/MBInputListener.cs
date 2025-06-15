using DecoyUserSystem.Implementations.MB;
using FlashlightSystem.Implementations.MB;
using GameSystem.Pause;
using InteractionSystem.Controller.Implementations.MB;
using LookSystem.Implementations.MB;
using MovementSystem.Implementations.MB;
using PlayerControlsProviderSystem;
using SpeedUpSystem.Implementations.MB;
using UnityEngine;

namespace InputActionsManagerSystem
{
    public class MBInputListener : MonoBehaviour
    {
        [SerializeField] private AMBMovementController movementController;
        [SerializeField] private AMBSpeedUpController speedUpController;
        [SerializeField] private AMBLookController lookController;
        [SerializeField] private AMBInteractionController interactionController;
        [SerializeField] private AMBFlashlight flashlight;
        [SerializeField] private MBGamePauseController gamePauseController;
        [SerializeField] private AMBDecoyUser decoyUser;
        
        [Space]
        [SerializeField] private MBPlayerControlsProvider playerControlsProvider;

        private InputListener _inputListener;

        private void Start()
        {
            _inputListener = new(movementController, speedUpController, lookController, interactionController, flashlight, gamePauseController, decoyUser);

            _inputListener.SetupInputActions(playerControlsProvider.PlayerControls);
        }
    }
}