using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspendedTrapDamage : MonoBehaviour
{
   
	public int valoareLovitura = 20;
 	public LayerMask playerLayer;
 	public Transform player;
 	
    void OnTriggerEnter2D(){
    	player.GetComponent<Player_attack>().esteLovit(valoareLovitura);
    }
}
