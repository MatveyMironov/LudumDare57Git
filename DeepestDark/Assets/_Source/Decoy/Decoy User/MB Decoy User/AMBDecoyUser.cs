using UnityEngine;

namespace DecoyUserSystem.Implementations.MB
{
    public abstract class AMBDecoyUser : MonoBehaviour, IDecoyUser
    {
        public abstract void UseDecoy();
    }
}