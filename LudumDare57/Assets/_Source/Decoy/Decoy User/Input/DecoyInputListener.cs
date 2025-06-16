using UnityEngine.InputSystem;

namespace DecoyUserSystem.Input
{
    public class DecoyInputListener
    {
        private readonly IDecoyUser _decoyUser;

        private PlayerControls.DecoyActions _decoyActions;

        public DecoyInputListener(IDecoyUser decoyUser)
        {
            _decoyUser = decoyUser ?? throw new System.ArgumentNullException(nameof(decoyUser));
        }

        public void SetupInputActions(PlayerControls.DecoyActions decoyActions)
        {
            _decoyActions = decoyActions;

            _decoyActions.UseDecoy.performed += OnUseDecoyInput;
        }

        public void UnsetupInputActions()
        {
            _decoyActions.UseDecoy.performed -= OnUseDecoyInput;
        }

        private void OnUseDecoyInput(InputAction.CallbackContext context)
        {
            _decoyUser.UseDecoy();
        }
    }
}