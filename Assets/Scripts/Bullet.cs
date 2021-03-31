using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float Bspeed;
    [SerializeField] private float Slowspeed;
    private float lifetime;
    [SerializeField] private float Nlifetime;
    [SerializeField] private int damage;
    [SerializeField] private ParticleSystem particle_System;
    private void Awake()
    {
        lifetime = Nlifetime;
    }
    private void Start()
    {
        particle_System.Play();
    }
    private void FixedUpdate()
    {

        transform.Translate(Vector3.forward * Bspeed * Time.deltaTime);
        lifetime -= Time.deltaTime;

        if (lifetime <= 0)
        {
            Destroy(this.gameObject);
            lifetime = Nlifetime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Enemy":
                Debug.Log(other.name);
                other.GetComponentInParent<EnemyStat>().TakeDamage(damage, other.name);
                Destroy(this.gameObject);
                break;
            case "Player":
                other.GetComponent<PlayerHP>().TakeDamage(damage, other.name);
                Destroy(this.gameObject);
                break;
        }
        if (other.CompareTag("SlowArea") && gameObject.CompareTag("EnemyBulet"))
        {
            Bspeed = Slowspeed;
            particle_System.Play();
        }
    }
}
