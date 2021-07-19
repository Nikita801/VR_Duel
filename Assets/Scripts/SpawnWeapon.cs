using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeapon : MonoBehaviour
{
    [SerializeField] private GameObject[] Guns;
    public GameObject Player;
    public GameObject PlayerSpawner;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Player.transform.position = PlayerSpawner.transform.position;
        Player.transform.rotation = PlayerSpawner.transform.rotation;
        Instantiate(Guns[GameControl.currentWeapon], transform.position, Quaternion.identity);
        //Instantiate(Guns[0], transform.position, Quaternion.identity);
        Debug.Log("Выбрано оружие" + GameControl.currentWeapon);
    }
}
