using PlayerControlsProviderSystem;
using UnityEngine;

namespace GameSystem.Pause.Input.MB
{
    public class MBPauseInputListener : MonoBehaviour
    {
        [SerializeField] private MBGamePauseController pauseController;

        [Space]
        [SerializeField] private AMBPlayerControlsProvider playerControlsProvider;

        private PauseInputListener _inputListener;

        private void Start()
        {
            _inputListener = new(pauseController);

            _inputListener.SetupInputActions(playerControlsProvider.PlayerControls.Pause);
        }
    }
}