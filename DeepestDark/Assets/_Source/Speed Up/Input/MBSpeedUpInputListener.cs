using PlayerControlsProviderSystem;
using SpeedUpSystem.Implementations.MB;
using UnityEngine;

namespace SpeedUpSystem.Input.MB
{
    public class MBSpeedUpInputListener : MonoBehaviour
    {
        [SerializeField] private AMBSpeedUpController interactionController;

        [Space]
        [SerializeField] private AMBPlayerControlsProvider playerControlsProvider;

        private SpeedUpInputListener _inputListener;

        private void Start()
        {
            _inputListener = new(interactionController);

            _inputListener.SetupInputActions(playerControlsProvider.PlayerControls.Movement);
        }
    }
}