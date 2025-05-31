using UnityEngine;

namespace MovementSystem
{
    public abstract class AMBMovementParameters : MonoBehaviour, IMovementParameters
    {
        public abstract float Speed { get; }
        public abstract float Acceleration { get; }
        public abstract float Deceleration { get; }
    }
}
