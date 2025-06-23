using UnityEngine;

namespace CollectionSystem.CollectedObjectDisplayer
{
    public abstract class AMBCollectedObjectDisplayer : MonoBehaviour
    {
        [SerializeField] private MBCollectableObject collectableObject;

        protected virtual void Start()
        {
            collectableObject.OnCollected += Test;
        }

        private void Test()
        {
            DisplayObjectBeingCollected();
        }

        protected abstract void DisplayObjectBeingCollected();
    }
}