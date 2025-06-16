using MovementSystem.Implementations.MB;
using PlayerControlsProviderSystem;
using UnityEngine;

namespace MovementSystem.Input.MB
{
    public class MBMovementInputListener : MonoBehaviour
    {
        [SerializeField] private AMBMovementController interactionController;

        [Space]
        [SerializeField] private AMBPlayerControlsProvider playerControlsProvider;

        private MovementInputListener _inputListener;

        private void Start()
        {
            _inputListener = new(interactionController);

            _inputListener.SetupInputActions(playerControlsProvider.PlayerControls.Movement);
        }
    }
}