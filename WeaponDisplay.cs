using UnityEngine;

public class WeaponDisplay : MonoBehaviour
{
    public WeaponData[] weapons;

    void Start()
    {
        foreach (WeaponData weapon in weapons)
        {
            Debug.Log("Weapon Type: " + weapon.weaponType);
            Debug.Log("Damage: " + weapon.damage);
            Debug.Log("Range: " + weapon.range);
            Debug.Log("--------------------------");
        }
    }
}
