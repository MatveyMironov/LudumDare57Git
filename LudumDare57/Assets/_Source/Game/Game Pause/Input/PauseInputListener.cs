using UnityEngine.InputSystem;

namespace GameSystem.Pause.Input
{
    public class PauseInputListener
    {
        private readonly IGamePauseController _gamePauseController;

        private PlayerControls.PauseActions _pauseActions;

        public PauseInputListener(IGamePauseController gamePauseController)
        {
            _gamePauseController = gamePauseController ?? throw new System.ArgumentNullException(nameof(gamePauseController));
        }

        public void SetupInputActions(PlayerControls.PauseActions pauseActions)
        {
            _pauseActions = pauseActions;

            _pauseActions.TogglePause.performed += OnPauseInput;
        }

        public void UnsetupInputActions()
        {
            _pauseActions.TogglePause.performed -= OnPauseInput;
        }

        private void OnPauseInput(InputAction.CallbackContext context)
        {
            if (_gamePauseController.IsPaused)
                _gamePauseController.UnpauseGame();
            else
                _gamePauseController.PauseGame();
        }
    }
}