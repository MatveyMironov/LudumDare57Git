using OxygenTankSystem.Implementations.MB;
using System;
using UnityEngine;

namespace OxygenConsumerSystem.Implementations.MB
{
    public abstract class AMBOxygenConsumer : MonoBehaviour, IOxygenConsumer
    {
        [SerializeField] protected AMBOxygenTank oxygenTank;

        protected abstract IOxygenConsumer OxygenConsumer { get; }

        public event Action OnSuffocationStarted
        {
            add => OxygenConsumer.OnSuffocationStarted += value;
            remove => OxygenConsumer.OnSuffocationStarted -= value;
        }

        public void StartConsuming()
        {
            OxygenConsumer.StartConsuming();
        }
    }
}
