using System;
using UnityEngine;

namespace MovementSystem.Implementations.MB.Parameters.Implementations
{
    [Serializable]
    public class SerializableMovementParameters : IMovementParameters
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public float Acceleration { get; private set; }
        [field: SerializeField] public float Deceleration { get; private set; }
    }
}
