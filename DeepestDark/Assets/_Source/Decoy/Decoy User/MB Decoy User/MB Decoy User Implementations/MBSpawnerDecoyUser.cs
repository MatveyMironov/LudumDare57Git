using DecoyInventorySystem.Implementations.MB;
using DecoySpawnerSystem.Implementations;
using DecoySystem;
using UnityEngine;

namespace DecoyUserSystem.Implementations.MB.Implementations
{
    public class MBSpawnerDecoyUser : AMBDecoyUser
    {
        [Header("Inventory")]
        [SerializeField] private AMBDecoyInventory decoyInventory;

        [Header("Spawner")]
        [SerializeField] private Decoy decoyPrefab;
        [SerializeField] private Transform decoysRoot;

        private DecoyUser _decoyUser;

        private DecoyUser DecoyUser
        {
            get
            {
                _decoyUser ??= new(decoyInventory, new DecoySpawner(decoyPrefab, transform, decoysRoot));

                return _decoyUser;
            }
        }

        public override void UseDecoy()
        {
            DecoyUser.UseDecoy();
        }
    }
}