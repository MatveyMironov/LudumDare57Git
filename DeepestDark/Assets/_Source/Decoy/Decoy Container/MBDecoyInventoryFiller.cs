using DecoyInventorySystem.Implementations.MB;
using UnityEngine;

namespace DecoysContainerSystem
{
    public class MBDecoyInventoryFiller : MonoBehaviour
    {
        [SerializeField] private AMBDecoyInventory decoyInventory;
        [SerializeField] private int startDecoys;

        private void Start()
        {
            decoyInventory.StoredDecoysCount = startDecoys;
        }
    }
}
