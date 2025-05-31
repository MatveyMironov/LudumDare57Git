using SpeedUpSystem;
using UnityEngine;

namespace MovementSystem
{
    public class MBSpeedUpControllerMovementParameters : AMBMovementParameters
    {
        [SerializeField] private float defaultSpeed;
        [SerializeField] private float defaultAcceleration;
        [SerializeField] private float defaultDeceleration;

        [Space]
        [SerializeField] private float speedUpSpeed;
        [SerializeField] private float speedUpAcceleration;
        [SerializeField] private float speedUpDeceleration;

        [Space]
        [SerializeField] private MBSpeedUpController speedUpController;

        private bool DoSpeedUp { get { return speedUpController.DoSpeedUp; } }
        public override float Speed { get { return DoSpeedUp ? speedUpSpeed : defaultSpeed; } }
        public override float Acceleration { get { return DoSpeedUp ? speedUpAcceleration : defaultAcceleration; } }
        public override float Deceleration { get { return DoSpeedUp ? speedUpDeceleration : defaultDeceleration; } }
    }
}
