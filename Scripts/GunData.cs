using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunData : MonoBehaviour
{
    [SerializeField] private GameObject pistolMesh;
    [SerializeField] private GameObject assaultRifleMesh;
    [SerializeField] private GameObject laserGunMesh;
    public GameObject PistolMesh => pistolMesh;
    public GameObject AssaultRifleMesh => assaultRifleMesh;
    public GameObject LaserGunMesh => laserGunMesh;
}
