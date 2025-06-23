using UnityEngine.InputSystem;

namespace SpeedUpSystem.Input
{
    public class SpeedUpInputListener
    {
        private readonly ISpeedUpController _speedUpController;

        PlayerControls.MovementActions _movementActions;

        public SpeedUpInputListener(ISpeedUpController speedUpController)
        {
            _speedUpController = speedUpController ?? throw new System.ArgumentNullException(nameof(speedUpController));
        }

        public void SetupInputActions(PlayerControls.MovementActions movementActions)
        {
            _movementActions = movementActions;

            _movementActions.SpeedUp.started += OnSpeedUpInput;
            _movementActions.SpeedUp.canceled += OnSpeedUpInput;
        }

        public void UnsetupInputActions()
        {
            _movementActions.SpeedUp.started -= OnSpeedUpInput;
            _movementActions.SpeedUp.canceled -= OnSpeedUpInput;
        }

        private void OnSpeedUpInput(InputAction.CallbackContext context)
        {
            _speedUpController.DoSpeedUp = context.ReadValueAsButton();
        }
    }
}