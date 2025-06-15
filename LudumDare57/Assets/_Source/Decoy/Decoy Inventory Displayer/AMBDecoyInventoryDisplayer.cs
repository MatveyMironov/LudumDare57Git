using DecoyInventorySystem;
using DecoyInventorySystem.Implementations.MB;
using UnityEngine;

namespace DecoyInventoryDisplayerSystem
{
    public abstract class AMBDecoyInventoryDisplayer : MonoBehaviour
    {
        [SerializeField] private AMBDecoyInventory inventory;

        private void Start()
        {
            DisplayDecoyInventory(inventory);
        }

        protected abstract void DisplayDecoyInventory(IDecoyInventory decoyInventory);
    }
}