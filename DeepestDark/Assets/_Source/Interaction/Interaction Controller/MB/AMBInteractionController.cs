using UnityEngine;

namespace InteractionSystem.Controller.Implementations.MB
{
    public abstract class AMBInteractionController : MonoBehaviour, IInteractionController
    {
        public abstract void Interact();
    }
}
