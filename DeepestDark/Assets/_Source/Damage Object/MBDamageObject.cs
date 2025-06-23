using UnityEngine;
using WeaponSystem;

public class MBDamageObject : MonoBehaviour
{ 
    [SerializeField] private Weapon.WeaponReferences weaponReferences;
    [SerializeField] private Weapon.WeaponParameters weaponParameters;

    private Weapon _weapon;

    private void Start()
    {
        _weapon = new(weaponReferences, weaponParameters);
    }

    public void DealDamage()
    {
        _weapon.Use();
        gameObject.SetActive(false);
    }
}
