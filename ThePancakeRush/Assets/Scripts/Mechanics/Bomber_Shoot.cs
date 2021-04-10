using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber_Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bombPrefab;
    Transform player;
    Rigidbody2D rb;

    public float attackRange = 3f;
    public float attackDelay = 1f;
    private float lastAttackTime;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            if(Time.time > lastAttackTime + attackDelay)
            {
                Shoot();
                lastAttackTime = Time.time;
            }
        }
    }

    void Shoot()
    {
        Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
    }
}
