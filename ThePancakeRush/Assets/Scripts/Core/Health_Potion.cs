using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Potion : MonoBehaviour
{
	public int healingValue = 20; 
	public GameObject player;
    // Start is called before the first frame update
    void Start()
    {   
    	player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
		player.GetComponent<Player_attack>().setLife(healingValue);
        Destroy(gameObject);
    }
}
