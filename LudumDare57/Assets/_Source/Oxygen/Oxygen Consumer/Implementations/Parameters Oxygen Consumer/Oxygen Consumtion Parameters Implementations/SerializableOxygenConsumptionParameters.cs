using System;
using UnityEngine;

namespace OxygenConsumerSystem.Implementations.Parameters.Implementations
{
    [Serializable]
    public class SerializableOxygenConsumptionParameters : IOxygenConsumptionParameters
    {
        [field: SerializeField] public float InhalesInterval { get; private set; }

        public event Action<float> OnInhalesIntervalChanged;
    }
}
