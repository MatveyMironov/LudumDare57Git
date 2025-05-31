using UnityEngine;

namespace MovementSystem
{
    public interface IMovementController
    {
        public Vector2 TargetVelocity { get; }
        public void Move(Vector2 direction);
    }
}
