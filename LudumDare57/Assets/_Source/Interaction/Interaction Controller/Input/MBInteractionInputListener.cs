using InteractionSystem.Controller.Implementations.MB;
using PlayerControlsProviderSystem;
using UnityEngine;

namespace InteractionSystem.Controller.Input.MB
{
    public class MBInteractionInputListener : MonoBehaviour
    {
        [SerializeField] private AMBInteractionController interactionController;
        
        [Space]
        [SerializeField] private AMBPlayerControlsProvider playerControlsProvider;

        private InteractionInputListener _inputListener;

        private void Start()
        {
            _inputListener = new(interactionController);

            _inputListener.SetupInputActions(playerControlsProvider.PlayerControls.Interaction);
        }
    }
}