using System;
using UnityEngine.InputSystem;

namespace FlashlightSystem.Input
{
    public class FlashlightInputListener
    {
        private readonly IFlashlight _flashlight;

        private PlayerControls.FlashlightActions _flashlightActions;

        public FlashlightInputListener(IFlashlight flashlight)
        {
            _flashlight = flashlight ?? throw new ArgumentNullException(nameof(flashlight));
        }

        public void SetupInputActions(PlayerControls.FlashlightActions flashlightActions)
        {
            _flashlightActions = flashlightActions;

            _flashlightActions.SwitchMode.performed += OnSwitchModeInput;
        }

        public void UnsetupInputActions()
        {
            _flashlightActions.SwitchMode.performed -= OnSwitchModeInput;
        }

        private void OnSwitchModeInput(InputAction.CallbackContext context)
        {
            float input = context.ReadValue<float>();

            if (input > 0f)
                _flashlight.SwitchToNextConfiguration();
            else if (input < 0f)
                _flashlight.SwitchToPreviousConfiguration();
        }
    }
}
