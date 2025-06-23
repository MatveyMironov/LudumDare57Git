using FlashlightSystem.Implementations.MB;
using PlayerControlsProviderSystem;
using UnityEngine;

namespace FlashlightSystem.Input.MB
{
    public class MBFlashlightInputListener : MonoBehaviour
    {
        [SerializeField] private AMBFlashlight flashlight;

        [Space]
        [SerializeField] private AMBPlayerControlsProvider playerControlsProvider;

        private FlashlightInputListener _inputListener;

        private void Start()
        {
            _inputListener = new(flashlight);

            _inputListener.SetupInputActions(playerControlsProvider.PlayerControls.Flashlight);
        }
    }
}
