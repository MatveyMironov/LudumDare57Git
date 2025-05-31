using MovementSystem;
using SpeedUpSystem;
using System;
using UnityEngine;

namespace OxygenConsumerSystem
{
    [Serializable]
    public class SerializableMovementDependentOxygenConsumptionParameters : IOxygenConsumptionParameters
    {
        [SerializeField] private MBMovementController movementController;
        [SerializeField] private MBSpeedUpController speedUpController;

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
