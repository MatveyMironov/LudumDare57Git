using System;
using UnityEngine;

namespace OxygenTankSystem.Implementations
{
    [Serializable]
    public class OxygenTankConfiguration
    {
        [SerializeField] private int maxOxygenAmount;

        public OxygenTank CreateOxygenTank { get { return new(maxOxygenAmount); } }
    }
}
