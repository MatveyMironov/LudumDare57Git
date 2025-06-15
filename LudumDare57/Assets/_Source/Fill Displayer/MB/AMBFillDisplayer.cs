using UnityEngine;

namespace FillDisplayerSystem.Implementations.MB
{
    public abstract class AMBFillDisplayer : MonoBehaviour, IFillDisplayer
    {
        public abstract void DisplayFill(float fill);
    }
}
