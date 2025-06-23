using System;
using UnityEngine;

namespace DecoyInventorySystem.Implementations.MB
{
    public abstract class AMBDecoyInventory : MonoBehaviour, IDecoyInventory
    {
        public abstract int MaxDecoysCount { get; set; }
        public abstract int StoredDecoysCount { get; set; }

        public abstract event Action<int> OnMaxDecoysCountChanched;
        public abstract event Action<int> OnStoredDecoysCountChanged;
    }
}
