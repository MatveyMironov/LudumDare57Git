using PerceptionSystem;
using UnityEngine;
using ValueDisplayerSystem.Implementations.MB;

namespace VisibilityDisplayerSystem
{
    public class MBVisibilityDisplayer : MonoBehaviour
    {
        [SerializeField] private AMBPercievedObject percievedObject;

        [SerializeField] private AMBValueDisplayer valueDisplayer;

        private void Update()
        {
            valueDisplayer.DisplayValue(percievedObject.Visibility);
        }
    }
}
