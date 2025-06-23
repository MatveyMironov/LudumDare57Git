using System;
using UnityEngine.InputSystem;

namespace InteractionSystem.Controller.Input
{
    public class InteractionInputListener
    {
        private readonly IInteractionController _interactionController;

        private PlayerControls.InteractionActions _interactionActions;

        public InteractionInputListener(IInteractionController interactionController)
        {
            _interactionController = interactionController ?? throw new ArgumentNullException(nameof(interactionController));
        }

        public void SetupInputActions(PlayerControls.InteractionActions interactionActions)
        {
            _interactionActions = interactionActions;

            _interactionActions.Interact.performed += OnInteractInput;
        }

        public void UnsetupInputActions()
        {
            _interactionActions.Interact.performed -= OnInteractInput;
        }

        private void OnInteractInput(InputAction.CallbackContext context)
        {
            _interactionController.Interact();
        }
    }
}