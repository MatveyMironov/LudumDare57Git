using MovementSystem.Implementations.MB;
using SpeedUpSystem.Implementations.MB;
using System;
using UnityEngine;

namespace OxygenConsumerSystem.Implementations.Parameters.Implementations
{
    [Serializable]
    public class SerializableMovementDependentOxygenConsumptionParameters : IOxygenConsumptionParameters
    {
        [SerializeField] private AMBMovementController movementController;
        [SerializeField] private AMBSpeedUpController speedUpController;

        [Space]
        [SerializeField] private float stillInhalesInterval;
        [SerializeField] private float movingInhalesInterval;
        [SerializeField] private float speedUpInhalesInterval;

        private MovementDependentOxygenConsumptionParameters _movementDependentOxygenConsumptionParameters;


        private MovementDependentOxygenConsumptionParameters MovementDependentOxygenConsumptionParameters
        {
            get
            {
                _movementDependentOxygenConsumptionParameters ??= new(movementController, speedUpController, stillInhalesInterval, movingInhalesInterval, speedUpInhalesInterval);

                return _movementDependentOxygenConsumptionParameters;
            }
        }

        public float InhalesInterval => MovementDependentOxygenConsumptionParameters.InhalesInterval;

        public event Action<float> OnInhalesIntervalChanged
        {
            add => MovementDependentOxygenConsumptionParameters.OnInhalesIntervalChanged += value;
            remove => MovementDependentOxygenConsumptionParameters.OnInhalesIntervalChanged -= value;
        }
    }
}
