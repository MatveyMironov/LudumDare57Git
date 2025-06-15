using PlayerControlsProviderSystem;
using UnityEngine;

namespace InputActionsManagerSystem.Implementations.MB.Implementations
{
    public class MBInputActionsManager : AMBInputActionsManager
    {
        [SerializeField] private MBPlayerControlsProvider playerControlsProvider;

        private InputActionsManager _inputActionsManager;

        private InputActionsManager InputActionsManager
        {
            get
            {
                _inputActionsManager ??= new(playerControlsProvider.PlayerControls);

                return _inputActionsManager;
            }
        }

        public override void DisableDecoyInput()
        {
            InputActionsManager.DisableDecoyInput();
        }

        public override void DisableFlashlightInput()
        {
            InputActionsManager.DisableFlashlightInput();
        }

        public override void DisableInteractionInput()
        {
            InputActionsManager.DisableInteractionInput();
        }

        public override void DisableMovementInput()
        {
            InputActionsManager.DisableMovementInput();
        }

        public override void DisablePauseInput()
        {
            InputActionsManager.DisablePauseInput();
        }

        public override void EnableDecoyInput()
        {
            InputActionsManager.EnableDecoyInput();
        }

        public override void EnableFlashlightInput()
        {
            InputActionsManager.EnableFlashlightInput();
        }

        public override void EnableInteractionInput()
        {
            InputActionsManager.EnableInteractionInput();
        }

        public override void EnableMovementInput()
        {
            InputActionsManager.EnableMovementInput();
        }

        public override void EnablePauseInput()
        {
            InputActionsManager.EnablePauseInput();
        }
    }
}
