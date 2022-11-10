using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            WeaponChange(GunType.Pistol);
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            WeaponChange(GunType.AssaultRifle);
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            WeaponChange(GunType.LaserGun);
    }

    private void WeaponChange(GunType gunType) => GetComponent<InventoryController>().SetGun(gunType);
}
