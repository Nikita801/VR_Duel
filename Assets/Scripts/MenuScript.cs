using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;

public class MenuScript : MonoBehaviour
{
    public SteamVR_LaserPointer Laser;
    public static bool ready;

    private void Update()
    {
        Debug.Log(ready);
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void AreYouReady()
    {
        ready = true;
        Laser.thickness = 0;
    }
}
