using UnityEngine;

namespace PlayerControlsProviderSystem
{
    public abstract class AMBPlayerControlsProvider : MonoBehaviour
    {
        public abstract PlayerControls PlayerControls { get; }
    }
}