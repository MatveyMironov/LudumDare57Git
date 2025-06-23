using UnityEngine;
using UnityEngine.InputSystem;

namespace MovementSystem.Input
{
    public class MovementInputListener
    {
        private readonly IMovementController _movementController;

        private PlayerControls.MovementActions _movementActions;

        public MovementInputListener(IMovementController movementController)
        {
            _movementController = movementController ?? throw new System.ArgumentNullException(nameof(movementController));
        }

        public void SetupInputActions(PlayerControls.MovementActions movementActions)
        {
            _movementActions = movementActions;

            _movementActions.Move.started += OnMoveInput;
            _movementActions.Move.performed += OnMoveInput;
            _movementActions.Move.canceled += OnMoveInput;
        }

        public void UnsetupInputActions()
        {
            _movementActions.Move.started -= OnMoveInput;
            _movementActions.Move.performed -= OnMoveInput;
            _movementActions.Move.canceled -= OnMoveInput;
        }

        private void OnMoveInput(InputAction.CallbackContext context)
        {
            Vector2 movementInput = context.ReadValue<Vector2>();
            _movementController.Move(movementInput);
        }
    }
}