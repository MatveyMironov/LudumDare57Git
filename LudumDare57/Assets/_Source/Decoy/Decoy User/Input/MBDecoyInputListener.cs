using DecoyUserSystem.Implementations.MB;
using PlayerControlsProviderSystem;
using UnityEngine;

namespace DecoyUserSystem.Input.MB
{
    public class MBDecoyInputListener : MonoBehaviour
    {
        [SerializeField] private AMBDecoyUser decoyUser;

        [Space]
        [SerializeField] private AMBPlayerControlsProvider playerControlsProvider;

        private DecoyInputListener _inputListener;

        private void Start()
        {
            _inputListener = new(decoyUser);

            _inputListener.SetupInputActions(playerControlsProvider.PlayerControls.Decoy);
        }
    }
}