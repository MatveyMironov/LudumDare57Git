using System;
using UnityEngine;

namespace OxygenConsumerSystem
{
    [Serializable]
    public class SerializableOxygenConsumptionParameters : IOxygenConsumptionParameters
    {
        [field: SerializeField] public float InhalesInterval { get; private set; }

        public event Action<float> OnInhalesIntervalChanged;
    }
}
