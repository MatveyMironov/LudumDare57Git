using System;

namespace OxygenConsumerSystem
{
    public interface IOxygenConsumptionParameters
    {
        public float InhalesInterval { get; }

        public event Action<float> OnInhalesIntervalChanged;
    }
}
