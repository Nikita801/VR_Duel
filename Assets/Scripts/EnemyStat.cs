using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStat : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rigid;
    public int health;
    [SerializeField] private Text text;

    private void Update()
    {
        text.text = health.ToString();
        if (health <= 0)
        {
            text.text = null;
        }
    }

    public void TakeDamage(int damage, string HitArea)
    {
        health -= damage;

        //switch (HitArea)
        //{
        //    case "VBOT_:Head":
        //        health -= damage * 2;
        //        text.text = "- " + damage;
        //        break;
        //}

        if (health <= 0)
        {
            health = Mathf.Clamp(health, 0, 100);
            Dead();
        }
        Debug.Log(damage);
    }

    void Dead()
    {
        foreach(Rigidbody rb in rigid)
        {
            rb.isKinematic = false;
        }
    }
}
