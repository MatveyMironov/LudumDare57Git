using UnityEngine;
using UnityEngine.InputSystem;

namespace LookSystem.Input
{
    public class LookInputListener
    {
        private readonly ILookController _lookController;

        private PlayerControls.MovementActions _movementActions;

        public LookInputListener(ILookController lookController)
        {
            _lookController = lookController ?? throw new System.ArgumentNullException(nameof(lookController));
        }

        public void SetupInputActions(PlayerControls.MovementActions movementActions)
        {
            _movementActions = movementActions;

            _movementActions.Look.started += OnLookInput;
            _movementActions.Look.performed += OnLookInput;
            _movementActions.Look.canceled += OnLookInput;
        }

        public void UnsetupInputActions()
        {
            _movementActions.Look.started -= OnLookInput;
            _movementActions.Look.performed -= OnLookInput;
            _movementActions.Look.canceled -= OnLookInput;
        }

        private void OnLookInput(InputAction.CallbackContext context)
        {
            _lookController.LookAt(context.ReadValue<Vector2>());
        }
    }
}