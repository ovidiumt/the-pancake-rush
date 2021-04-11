using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber_Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bombPrefab;

    void Shoot()
    {
        Instantiate(bombPrefab, firePoint.position, firePoint.rotation);
    }
}
