using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private List<GameObject> inventory;
    private GunType gunType;
    private GunData gunData;

    private void Start()
    {
        inventory = new();
        gunData = GetComponent<GunData>();
        LoadGuns();
    }

    public void SetGun(GunType gunType) => this.gunType = gunType;

    private void Update()
    {
        switch ((int)gunType)
        {
            case (int)GunType.Pistol:
                DisableAllGuns();
                inventory[0].SetActive(true);
                break;
            case (int)GunType.AssaultRifle:
                DisableAllGuns();
                inventory[1].SetActive(true);
                break;
            case (int)GunType.LaserGun:
                DisableAllGuns();
                inventory[2].SetActive(true);
                break;
        }
    }

    private void LoadGuns()
    {
        inventory.Add(gunData.PistolMesh);
        inventory.Add(gunData.AssaultRifleMesh);
        inventory.Add(gunData.LaserGunMesh);
    }

    private void DisableAllGuns()
    {
        foreach (var gun in inventory)
        {
            gun.SetActive(false);
        }
    }
}
