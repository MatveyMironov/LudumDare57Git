using InteractionSystem.Data.Implementations.MB;
using InteractionSystem.InteractionFinder;
using UnityEngine;

namespace InteractionSystem.Controller.Implementations.MB.Implementations
{
    public class MBInteractionController : AMBInteractionController
    {
        [SerializeField] private MBInteractionFinder interactionFinder;
        [SerializeField] private AMBInteractionData interactionData;

        private InteractionController _interactionController;

        private InteractionController InteractionController
        {
            get
            {
                _interactionController ??= new(interactionFinder, interactionData);

                return _interactionController;
            }
        }

        private void OnEnable()
        {
            _interactionController ??= new(interactionFinder, interactionData);
        }

        public override void Interact()
        {
            InteractionController.Interact();
        }
    }
}
