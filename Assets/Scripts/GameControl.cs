using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject RightButtonW;
    [SerializeField] private GameObject LeftButtonW;
    [SerializeField] private GameObject RightButtonL;
    [SerializeField] private GameObject LeftButtonL;

    public static int currentWeapon = 0;
    public static int currentLocation = 0;

    [SerializeField] private GameObject[] locations;
    [SerializeField] private GameObject[] weapons;

    private void Update()
    {
        if (RightButtonW.activeSelf||LeftButtonW.activeSelf)
        {
            weapons[currentWeapon].SetActive(true);
            for(int i=0; i<weapons.Length; i++)
            {
                if (i != currentWeapon)
                {
                    weapons[i].SetActive(false);
                }
            }
        }
        else
        {
            for (int i = 0; i < weapons.Length; i++)
            {
                weapons[i].SetActive(false);
            }
        }
        if (RightButtonL.activeSelf || LeftButtonL.activeSelf)
        {
            locations[currentLocation].SetActive(true);
            for (int i = 0; i < weapons.Length; i++)
            {
                if (i != currentWeapon)
                {
                    locations[i].SetActive(false);
                }
            }
        }
        else
        {
            for (int i = 0; i < locations.Length; i++)
            {
                locations[i].SetActive(false);
            }
        }
    }
    public void SelectWeapon()
    {
        if (locations[currentLocation].activeSelf || RightButtonL.activeSelf || LeftButtonL.activeSelf)
        {
            RightButtonL.SetActive(false);
            LeftButtonL.SetActive(false);
        }
        RightButtonW.SetActive(true);
        LeftButtonW.SetActive(true);
    }
    public void SelectLocation()
    {
        if (weapons[currentWeapon].activeSelf || RightButtonW.activeSelf || LeftButtonW.activeSelf)
        {
            RightButtonW.SetActive(false);
            LeftButtonW.SetActive(false);
        }
        RightButtonL.SetActive(true);
        LeftButtonL.SetActive(true);
    }

    public void RightNextW()
    {
        currentWeapon = (currentWeapon+1)%weapons.Length;
    }
    public void LeftNextW()
    {
        currentWeapon = (currentWeapon - 1) % weapons.Length;
    }
    public void RightNextL()
    {
        currentLocation = (currentLocation + 1) % locations.Length;
    }
    public void LeftNextL()
    {
        currentLocation = (currentLocation - 1) % locations.Length;
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(currentLocation.ToString());
    }
}
