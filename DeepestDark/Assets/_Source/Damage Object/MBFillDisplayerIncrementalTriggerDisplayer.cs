using FillDisplayerSystem.Implementations.MB;
using UnityEngine;

namespace Assets._Source.Damage_Object
{
    public class MBFillDisplayerIncrementalTriggerDisplayer : MonoBehaviour
    {
        [SerializeField] private MBIncrementalTrigger incrementalTrigger;

        [SerializeField] private AMBFillDisplayer fillDisplayer;

        private void Start()
        {
            incrementalTrigger.OnTriggerAmountChanged += fillDisplayer.DisplayFill;
        }
    }
}