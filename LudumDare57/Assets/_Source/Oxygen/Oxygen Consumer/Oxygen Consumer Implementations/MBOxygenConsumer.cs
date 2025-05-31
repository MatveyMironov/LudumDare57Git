using UnityEngine;

namespace OxygenConsumerSystem
{
    public class MBOxygenConsumer : AMBOxygenConsumer
    {
        [Space]
        [SerializeField] private SerializableOxygenConsumptionParameters oxygenConsumptionParameters;

        private OxygenConsumer _oxygenConsumer;

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
