using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Shoot : MonoBehaviour
{
    private float lastAttackTime;
    public float attackDelay;
    public float attackRange;

    public Transform firePoint;
    public GameObject bombPrefab;
    Transform player;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            if (Time.time > lastAttackTime + attackDelay)
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
