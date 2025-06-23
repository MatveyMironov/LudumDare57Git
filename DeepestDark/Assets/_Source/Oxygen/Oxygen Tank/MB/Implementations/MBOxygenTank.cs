using System;
using UnityEngine;

namespace OxygenTankSystem.Implementations.MB.Implementations
{
    public class MBOxygenTank : AMBOxygenTank
    {
        [SerializeField] private OxygenTankConfiguration configuration;

        private OxygenTank _oxygenTank;

        private OxygenTank OxygenTank
        {
            get
            {
                _oxygenTank ??= configuration.CreateOxygenTank;

                return _oxygenTank;
            }
        }

        public override int MaxOxygenAmount => OxygenTank.MaxOxygenAmount;

        public override int OxygenAmount { get => OxygenTank.OxygenAmount; set => OxygenTank.OxygenAmount = value; }

        public override event Action<int> OnOxygenAmountChanged { add { OxygenTank.OnOxygenAmountChanged += value; } remove { OxygenTank.OnOxygenAmountChanged -= value; } }
    }
}
