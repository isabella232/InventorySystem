using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : MonoBehaviour, IGun
{
    private GunType gunType = GunType.AssaultRifle;
    public GunType GunType => gunType;
}
