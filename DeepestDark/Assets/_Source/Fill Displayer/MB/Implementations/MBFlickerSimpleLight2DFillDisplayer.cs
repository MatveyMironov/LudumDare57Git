using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace FillDisplayerSystem.Implementations.MB.Implementations
{
    public class MBFlickerSimpleLight2DFillDisplayer : AMBFlickerFillDisplayer
    {
        [SerializeField] private Light2D light2D;

        [Header("Low")]
        [SerializeField] private float lowIntensity;
        [SerializeField] private float lowInnerRadius;
        [SerializeField] private float lowOuterRadius;
        [SerializeField] private float lowFalloffStrength;

        [Header("High")]
        [SerializeField] private float highIntensity;
        [SerializeField] private float highInnerRadius;
        [SerializeField] private float highOuterRadius;
        [SerializeField] private float highFalloffStrength;

        [Header("Empty")]
        [SerializeField] private float emptyLowDuration;
        [SerializeField] private float emptyIncreaseDuration;
        [SerializeField] private float emptyHighDuration;
        [SerializeField] private float emptyDecreaseDuration;

        [Header("Full")]
        [SerializeField] private float fullLowDuration;
        [SerializeField] private float fullIncreaseDuration;
        [SerializeField] private float fullHighDuration;
        [SerializeField] private float fullDecreaseDuration;

        protected override void Flicker(float flicker)
        {
            flicker = (flicker + 1) / 2;

            light2D.intensity = Mathf.Lerp(lowIntensity, highIntensity, flicker);
            light2D.pointLightInnerRadius = Mathf.Lerp(lowInnerRadius, highInnerRadius, flicker);
            light2D.pointLightOuterRadius = Mathf.Lerp(lowOuterRadius, highOuterRadius, flicker);
            light2D.falloffIntensity = Mathf.Lerp(lowFalloffStrength, highFalloffStrength, flicker);
        }
    }
}