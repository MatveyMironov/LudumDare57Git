using UnityEngine;

namespace FillDisplayerSystem.Implementations.MB.Implementations
{
    public abstract class AMBFlickerFillDisplayer : AMBFillDisplayer
    {
        [SerializeField] private float emptyFlickeringPeriod;
        [SerializeField] private float fullFlickeringPeriod;

        private float _fill;

        private float FlickeringPeriod { get => Mathf.Lerp(emptyFlickeringPeriod, fullFlickeringPeriod, _fill); }

        private void Update()
        {
            float flicker = Mathf.Sin(Time.time / FlickeringPeriod * Mathf.PI);
            
            Flicker(flicker);
        }

        public override void DisplayFill(float fill)
        {
            _fill = fill;
        }

        protected abstract void Flicker(float flicker);
    }
}