using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] private GameObject[] Guns;

    private void Awake()
    {
        Instantiate(Guns[GameControl.currentWeapon], transform.position, Quaternion.identity);
    }
}
