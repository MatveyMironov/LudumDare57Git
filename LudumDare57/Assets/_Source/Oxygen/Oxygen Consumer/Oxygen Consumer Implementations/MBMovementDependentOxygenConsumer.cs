using UnityEngine;

namespace OxygenConsumerSystem
{
    public class MBMovementDependentOxygenConsumer : AMBOxygenConsumer
    {
        [Space]
        [SerializeField] private SerializableMovementDependentOxygenConsumptionParameters oxygenConsumptionParameters;

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
