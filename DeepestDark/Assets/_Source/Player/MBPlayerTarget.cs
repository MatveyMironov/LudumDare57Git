using OxygenTankSystem.Implementations.MB;
using UnityEngine;
using WeaponSystem;

namespace PlayerSystem
{
    public class MBPlayerTarget : MonoBehaviour, ITarget
    {
        [SerializeField] private AMBOxygenTank oxygenTank;

        public void RecieveDamage(int damage)
        {
            oxygenTank.OxygenAmount -= damage;
        }
    }
}
