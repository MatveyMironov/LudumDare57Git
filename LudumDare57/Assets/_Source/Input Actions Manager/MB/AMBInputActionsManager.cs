using UnityEngine;

namespace InputActionsManagerSystem.Implementations.MB
{
    public abstract class AMBInputActionsManager : MonoBehaviour, IInputActionsManager
    {
        public abstract void DisableDecoyInput();
        public abstract void DisableFlashlightInput();

        public abstract void DisableInteractionInput();
        public abstract void DisableMovementInput();

        public abstract void DisablePauseInput();
        public abstract void EnableDecoyInput();

        public abstract void EnableFlashlightInput();
        public abstract void EnableInteractionInput();

        public abstract void EnableMovementInput();
        public abstract void EnablePauseInput();
    }
}
