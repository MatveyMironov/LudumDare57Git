using System;
using UnityEngine;
using UnityEngine.Events;

namespace CollectionSystem
{
    public class MBCollection : MonoBehaviour
    {
        [SerializeField] private MBCollectableObject[] collectedObjects = new MBCollectableObject[0];

        public event Action<int> OnObjectsCollected;

        public UnityEvent OnAllObjectsCollected;

        private void Start()
        {
            foreach (var collectableObject in collectedObjects)
            {
                collectableObject.OnCollected += CheckIfAllObjectCollected;
            }
        }

        private void CheckIfAllObjectCollected()
        {
            int collectedObjectsCount = 0;
            bool allObjectsCollected = true;

            foreach (var collectableObject in collectedObjects)
            {
                if (!collectableObject.IsCollected)
                    allObjectsCollected = false;
                else
                    collectedObjectsCount++;
            }

            OnObjectsCollected?.Invoke(collectedObjectsCount);

            if (allObjectsCollected)
                OnAllObjectsCollected?.Invoke();
        }
    }
}
