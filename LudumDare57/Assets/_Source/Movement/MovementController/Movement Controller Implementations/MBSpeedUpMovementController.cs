using UnityEngine;

namespace MovementSystem
{
    public class MBSpeedUpMovementController : AMBMovementController
    {
        [Space]
        [SerializeField] private SerializableSpeedUpMovementParameters parameters;

        protected override IMovementParameters Parameters { get => parameters; }
    }
}
