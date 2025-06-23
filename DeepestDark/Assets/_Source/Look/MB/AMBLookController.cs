using UnityEngine;

namespace LookSystem.Implementations.MB
{
    public abstract class AMBLookController : MonoBehaviour, ILookController
    {
        public abstract void LookAt(Vector2 mouseScreenPosition);
    }
}
