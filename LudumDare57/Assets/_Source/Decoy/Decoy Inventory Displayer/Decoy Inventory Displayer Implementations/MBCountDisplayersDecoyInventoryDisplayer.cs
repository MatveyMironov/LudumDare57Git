using DecoyInventorySystem;
using UnityEngine;
using ValueDisplayerSystem.Implementations.MB;

namespace DecoyInventoryDisplayerSystem.Implementations
{
    public class MBCountDisplayersDecoyInventoryDisplayer : AMBDecoyInventoryDisplayer
    {
        [SerializeField] private AMBValueDisplayer maxDecoysCountDisplayer;
        [SerializeField] private AMBValueDisplayer storedDecoysCountDisplayer;

        protected override void DisplayDecoyInventory(IDecoyInventory decoyInventory)
        {
            DisplayMaxDecoysCount(decoyInventory.MaxDecoysCount);
            decoyInventory.OnMaxDecoysCountChanched += DisplayMaxDecoysCount;

            DisplayStoredDecoysCount(decoyInventory.StoredDecoysCount);
            decoyInventory.OnStoredDecoysCountChanged += DisplayStoredDecoysCount;
        }

        private void DisplayMaxDecoysCount(int maxDecoysCount)
        {
            maxDecoysCountDisplayer.DisplayValue(maxDecoysCount);
        }

        private void DisplayStoredDecoysCount(int storedDecoysCount)
        {
            storedDecoysCountDisplayer.DisplayValue(storedDecoysCount);
        }
    }
}
