using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem.Sample;
using Valve.VR.InteractionSystem;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] public float playerhealth;
    [SerializeField] private GameObject Damage;
    [SerializeField] private GameObject PauseMenu;
    private float Timer;
    [SerializeField] private float StartTimer;
    [SerializeField] private GameObject Weapon;
    public SkeletonUIOptions skeletonUI;
    //public RenderModelChangerUI renderModel;
    public RenderModelChangerUI Gloves;
    public void Awake()
    {
        Weapon = GameObject.FindGameObjectWithTag("Weapon");
    }
    //private void Start()
    //{
    //    Damage.color = Color.clear;
    //}
    //private void Update()
    //{
    //    //if (Timer <= 0)
    //    //{
    //    //    Damage.color = Color.clear;
    //    //    //Color c = Damage.color;
    //    //    //c.a = 0xFF;
    //    //    //Damage.color = c;
    //    //}
    //    //else
    //    //{
    //    //    Damage.color = Color.white;

    //    //    Timer -= Time.deltaTime;
    //    //}
    //}
    public void TakeDamage(int damage, string HitArea)
    {
        Debug.Log(damage);

        playerhealth -= damage;
        //Damage.color = Color.white;

        Timer = StartTimer;

        if (playerhealth <= 0)
        {
            PlayerDead();
        }
    }
    public void PlayerDead()
    {
        Damage.SetActive(true);
        skeletonUI.AnimateHandWithController();
        MenuScript.ready = false;
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        skeletonUI.AnimateHandWithController();
        MenuScript.ready = false;
    }
    //public void ShowController()
    //{
    //    for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
    //    {
    //        Hand hand = Player.instance.hands[handIndex];
    //        if (hand != null)
    //        {
    //            hand.ShowController(true);
    //        }
    //    }
    //}
}
