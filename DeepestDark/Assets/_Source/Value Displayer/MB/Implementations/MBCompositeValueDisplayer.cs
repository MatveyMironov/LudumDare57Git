using UnityEngine;

namespace ValueDisplayerSystem.Implementations.MB.Implementations
{
    public class MBCompositeValueDisplayer : AMBValueDisplayer
    {
        [SerializeField] private AMBValueDisplayer[] valueDisplayers = new AMBValueDisplayer[0];

        public override void DisplayValue(float value)
        {
            foreach (var valueDisplayer in valueDisplayers)
                valueDisplayer.DisplayValue(value);
        }
    }
}
