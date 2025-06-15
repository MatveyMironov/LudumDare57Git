using UnityEngine;

namespace SpeedUpSystem.Implementations.MB
{
    public abstract class AMBSpeedUpController : MonoBehaviour, ISpeedUpController
    {
        public abstract bool DoSpeedUp { get; set; }
    }
}
