using System;
using UnityEngine;
using UnityEngine.Events;

namespace CollectionSystem
{
    public class MBCollection : MonoBehaviour
    {
        [SerializeField] private CollectableObjectWrapper[] collectableObjectWrappers = new CollectableObjectWrapper[0];

        public UnityEvent<int> OnObjectsCollected;
        public UnityEvent OnAllObjectsCollected;

        private void Start()
        {
            foreach (var collectableObjectWrapper in collectableObjectWrappers)
            {
                collectableObjectWrapper.CollectableObject.OnCollected += collectableObjectWrapper.OnObjectCollected.Invoke;
                collectableObjectWrapper.CollectableObject.OnCollected += CheckIfAllObjectCollected;
            }
        }

        private void CheckIfAllObjectCollected()
        {
            int collectedObjectsCount = 0;
            bool allObjectsCollected = true;

            foreach (var collectableObjectWrapper in collectableObjectWrappers)
            {
                if (!collectableObjectWrapper.CollectableObject.IsCollected)
                    allObjectsCollected = false;
                else
                    collectedObjectsCount++;
            }

            OnObjectsCollected?.Invoke(collectedObjectsCount);

            if (allObjectsCollected)
                OnAllObjectsCollected?.Invoke();
        }

        [Serializable]
        private class CollectableObjectWrapper
        {
            [field: SerializeField] public MBCollectableObject CollectableObject { get; private set; }
            [field: SerializeField] public UnityEvent OnObjectCollected { get; private set; }
        }
    }
}
