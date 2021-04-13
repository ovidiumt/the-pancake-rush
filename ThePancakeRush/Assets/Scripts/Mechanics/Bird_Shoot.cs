using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Shoot : MonoBehaviour
{
    private float lastAttackTime;
    public float attackDelay;

    public Transform firePoint;
    public GameObject bombPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastAttackTime + attackDelay)
        {
            Shoot();
            lastAttackTime = Time.time;
        }
    }

    void Shoot()
    {
        Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
    }
}
