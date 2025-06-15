using UnityEngine;

namespace ClosableUISystem.Implementations.MB
{
    public abstract class AMBClosableUI : MonoBehaviour, IClosableUI
    {
        public abstract void Open();
        public abstract void Close();
    }
}
