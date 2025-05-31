using UnityEngine;

namespace MovementSystem
{
    public class MBMovementController : AMBMovementController
    {
        [Space]
        [SerializeField] private SerializableMovementParameters parameters;

        protected override IMovementParameters Parameters { get => parameters; }
    }
}
