using UnityEngine;

namespace LookSystem
{
    public interface ILookController
    {
        public void LookAt(Vector2 mouseScreenPosition);
    }
}
