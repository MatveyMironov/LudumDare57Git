using UnityEngine;

namespace MovementSystem.Implementations.MB.Parameters.Implementations
{
    public class MBSerializableParametersMovementController : AMBParametersMovementController
    {
        [Space]
        [SerializeField] private SerializableMovementParameters parameters;

        protected override IMovementParameters Parameters { get => parameters; }
    }
}
