using System;
using UnityEngine;

namespace DecoyInventorySystem.Implementations.MB.Implementations
{
    public class MBDecoyInventory : AMBDecoyInventory
    {
        [SerializeField] private int baseMaxDecoys;
        [SerializeField] protected int startDecoys;

        private DecoyInventory _inventory;

        private DecoyInventory Inventory
        {
            get
            {
                _inventory ??= new()
                {
                    MaxDecoysCount = baseMaxDecoys,
                    StoredDecoysCount = startDecoys
                };

                return _inventory;
            }
        }

        public override int MaxDecoysCount { get => Inventory.MaxDecoysCount; set { Inventory.MaxDecoysCount = value; } }
        public override int StoredDecoysCount { get => Inventory.StoredDecoysCount; set { Inventory.StoredDecoysCount = value; } }

        public override event Action<int> OnMaxDecoysCountChanched { add { Inventory.OnMaxDecoysCountChanched += value; } remove { Inventory.OnMaxDecoysCountChanched -= value; } }
        public override event Action<int> OnStoredDecoysCountChanged { add { Inventory.OnStoredDecoysCountChanged += value; } remove { Inventory.OnStoredDecoysCountChanged -= value; } }
    }
}
