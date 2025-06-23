using UnityEngine;

namespace ValueDisplayerSystem.Implementations.MB
{
    public abstract class AMBValueDisplayer : MonoBehaviour, IValueDisplayer
    {
        public abstract void DisplayValue(float value);
    }
}
