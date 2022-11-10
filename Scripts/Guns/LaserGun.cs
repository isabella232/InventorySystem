using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour, IGun
{
    private GunType gunType = GunType.LaserGun;
    public GunType GunType => gunType;
}
