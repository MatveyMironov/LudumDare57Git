using UnityEngine;

namespace PlayerControlsProviderSystem
{
    internal class MBRelayPlayerControlsProvider : AMBPlayerControlsProvider
    {
        [SerializeField] private AMBPlayerControlsProvider playerControlsProvider;

        public override PlayerControls PlayerControls => playerControlsProvider.PlayerControls;
    }
}