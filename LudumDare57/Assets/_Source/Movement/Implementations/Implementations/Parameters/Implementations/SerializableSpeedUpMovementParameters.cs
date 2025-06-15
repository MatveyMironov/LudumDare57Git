using SpeedUpSystem.Implementations.MB;
using System;
using UnityEngine;

namespace MovementSystem.Implementations.MB.Parameters.Implementations
{
    [Serializable]
    public class SerializableSpeedUpMovementParameters : IMovementParameters
    {
        [SerializeField] private float defaultSpeed;
        [SerializeField] private float defaultAcceleration;
        [SerializeField] private float defaultDeceleration;

        [Space]
        [SerializeField] private float speedUpSpeed;
        [SerializeField] private float speedUpAcceleration;
        [SerializeField] private float speedUpDeceleration;

        [Space]
        [SerializeField] private AMBSpeedUpController speedUpController;

        private bool DoSpeedUp { get { return speedUpController.DoSpeedUp; } }
        public float Speed { get { return DoSpeedUp ? speedUpSpeed : defaultSpeed; } }
        public float Acceleration { get { return DoSpeedUp ? speedUpAcceleration : defaultAcceleration; } }
        public float Deceleration { get { return DoSpeedUp ? speedUpDeceleration : defaultDeceleration; } }
    }
}
