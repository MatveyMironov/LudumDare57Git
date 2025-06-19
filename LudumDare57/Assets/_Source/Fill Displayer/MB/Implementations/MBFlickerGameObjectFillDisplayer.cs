using UnityEngine;

namespace FillDisplayerSystem.Implementations.MB.Implementations
{
    public class MBFlickerGameObjectFillDisplayer : AMBFlickerFillDisplayer
    {
        [Space]
        [SerializeField] private MonoBehaviour _object;

        protected override void Flicker(float flicker)
        {
            if (flicker > 0)
                _object.enabled = true;
            else
                _object.enabled = false;
        }
    }
}