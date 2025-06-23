using OxygenConsumerSystem.Implementations.Parameters;
using OxygenConsumerSystem.Implementations.Parameters.Implementations;
using UnityEngine;

namespace OxygenConsumerSystem.Implementations.MB.Implementations
{
    public class MBSerializableParametersOxygenConsumer : AMBOxygenConsumer
    {
        [Space]
        [SerializeField] private SerializableOxygenConsumptionParameters oxygenConsumptionParameters;

        private ParametersOxygenConsumer _oxygenConsumer;

        protected override IOxygenConsumer OxygenConsumer
        {
            get
            {
                _oxygenConsumer ??= new(oxygenConsumptionParameters, oxygenTank, this);

                return _oxygenConsumer;
            }
        }
    }
}
