using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour, IGun
{
    private GunType gunType = GunType.Pistol;
    public GunType GunType => gunType;
}
