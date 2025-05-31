using MovementSystem;
using SpeedUpSystem;
using System;

namespace OxygenConsumerSystem
{
    public class MovementDependentOxygenConsumptionParameters : IOxygenConsumptionParameters
    {
        private readonly IMovementController _movementController;
        private readonly ISpeedUpController _speedUpController;

        private readonly float _stillInhalesInterval;
        private readonly float _movingInhalesInterval;
        private readonly float _speedUpInhalesInterval;

        public MovementDependentOxygenConsumptionParameters(IMovementController movementController,
                                                            ISpeedUpController speedUpController,
                                                            float stillInhalesInterval,
                                                            float movingInhalesInterval,
                                                            float speedUpInhalesInterval)
        {
            _movementController = movementController ?? throw new ArgumentNullException(nameof(movementController));
            _speedUpController = speedUpController ?? throw new ArgumentNullException(nameof(speedUpController));

            _stillInhalesInterval = stillInhalesInterval;
            _movingInhalesInterval = movingInhalesInterval;
            _speedUpInhalesInterval = speedUpInhalesInterval;
        }

        public float InhalesInterval { get { return GetInhalesInterval(); } }

        public event Action<float> OnInhalesIntervalChanged;

        private float GetInhalesInterval()
        {
            if (_movementController.TargetVelocity.magnitude > 0.0f)
            {
                if (_speedUpController.DoSpeedUp)
                {
                    return _speedUpInhalesInterval;
                }

                return _movingInhalesInterval;
            }

            return _stillInhalesInterval;
        }
    }
}
