using UnityEngine;

namespace MovementSystem.Implementations.MB
{
    public abstract class AMBMovementController : MonoBehaviour, IMovementController
    {
        public abstract Vector2 TargetVelocity { get; }

        public abstract void Move(Vector2 direction);
    }
}
