using OxygenTankSystem;
using System;
using UnityEngine;

namespace OxygenConsumerSystem
{
    public abstract class AMBOxygenConsumer : MonoBehaviour, IOxygenConsumer
    {
        [SerializeField] protected MBOxygenTank oxygenTank;

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
