using UnityEngine;

namespace InteractionSystem.Data.Implementations.MB
{
    public abstract class AMBInteractionData : MonoBehaviour, IInteractionData
    {
        public abstract bool TryAddService<T>(T service);
        public abstract bool TryGetService<T>(out T service);
        public abstract bool TryRemoveService<T>();
    }
}
