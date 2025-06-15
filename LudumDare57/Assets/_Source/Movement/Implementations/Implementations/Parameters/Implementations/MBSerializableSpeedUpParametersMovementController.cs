using UnityEngine;

namespace MovementSystem.Implementations.MB.Parameters.Implementations
{
    public class MBSerializableSpeedUpParametersMovementController : AMBParametersMovementController
    {
        [Space]
        [SerializeField] private SerializableSpeedUpMovementParameters parameters;

        protected override IMovementParameters Parameters { get => parameters; }
    }
}
