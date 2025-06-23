using UnityEngine;
using UnityEngine.UI;

namespace CollectionSystem.CollectedObjectDisplayer
{
    public class MBImageCollectedObjectDisplayer : AMBCollectedObjectDisplayer
    {
        [Space]
        [SerializeField] private Image collectedObjectImage;

        protected override void Start()
        {
            base.Start();
            collectedObjectImage.enabled = false;
        }

        protected override void DisplayObjectBeingCollected()
        {
            collectedObjectImage.enabled = true;
        }
    }
}
