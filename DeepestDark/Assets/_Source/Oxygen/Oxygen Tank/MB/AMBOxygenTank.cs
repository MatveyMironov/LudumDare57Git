using System;
using UnityEngine;

namespace OxygenTankSystem.Implementations.MB
{
    public abstract class AMBOxygenTank : MonoBehaviour, IOxygenTank
    {
        public abstract int MaxOxygenAmount { get; }
        public abstract int OxygenAmount { get; set; }

        public abstract event Action<int> OnOxygenAmountChanged;
    }
}
