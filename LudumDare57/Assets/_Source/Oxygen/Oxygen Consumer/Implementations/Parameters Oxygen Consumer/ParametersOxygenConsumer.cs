using OxygenTankSystem;
using System;
using System.Collections;
using UnityEngine;

namespace OxygenConsumerSystem.Implementations.Parameters
{
    public class ParametersOxygenConsumer : IOxygenConsumer
    {
        private readonly IOxygenConsumptionParameters _oxygenConsumptionParameters;
        private readonly IOxygenTank _oxygenTank;
        private readonly MonoBehaviour _monoBehaviour;

        public ParametersOxygenConsumer(IOxygenConsumptionParameters oxygenConsumptionParameters, IOxygenTank oxygenTank, MonoBehaviour monoBehaviour)
        {
            _oxygenConsumptionParameters = oxygenConsumptionParameters ?? throw new ArgumentNullException(nameof(oxygenConsumptionParameters));
            _oxygenTank = oxygenTank ?? throw new ArgumentNullException(nameof(oxygenTank));
            _monoBehaviour = monoBehaviour != null ? monoBehaviour : throw new ArgumentNullException(nameof(monoBehaviour));
        }

        public event Action OnSuffocationStarted;

        public void StartConsuming()
        {
            _monoBehaviour.StartCoroutine(ConsumingOxygen());
        }

        private IEnumerator ConsumingOxygen()
        {
            float timer = 0f;

            while (true)
            {
                yield return null;

                timer += Time.deltaTime;

                if (timer >= _oxygenConsumptionParameters.InhalesInterval)
                {
                    timer -= _oxygenConsumptionParameters.InhalesInterval;

                    if (_oxygenTank.OxygenAmount > 0)
                        _oxygenTank.OxygenAmount -= 1;
                    else
                        OnSuffocationStarted?.Invoke();
                }
            }
        }
    }
}
