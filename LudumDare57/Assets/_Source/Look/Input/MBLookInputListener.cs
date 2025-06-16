using LookSystem.Implementations.MB;
using PlayerControlsProviderSystem;
using UnityEngine;

namespace LookSystem.Input.MB
{
    public class MBLookInputListener : MonoBehaviour
    {
        [SerializeField] private AMBLookController lookController;

        [Space]
        [SerializeField] private AMBPlayerControlsProvider playerControlsProvider;

        private LookInputListener _inputListener;

        private void Start()
        {
            _inputListener = new(lookController);

            _inputListener.SetupInputActions(playerControlsProvider.PlayerControls.Movement);
        }
    }
}