using UnityEngine;

namespace FlashlightSystem.Implementations.MB
{
    public abstract class AMBFlashlight : MonoBehaviour, IFlashlight
    {
        public abstract int CurrentConfigurationIndex { get; }

        public abstract void SwitchToConfiguration(int index);
        public abstract void SwitchToNextConfiguration();
        public abstract void SwitchToPreviousConfiguration();
    }
}
