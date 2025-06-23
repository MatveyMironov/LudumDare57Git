using System;

namespace OxygenConsumerSystem.Implementations.Parameters
{
    public interface IOxygenConsumptionParameters
    {
        public float InhalesInterval { get; }

        public event Action<float> OnInhalesIntervalChanged;
    }
}
