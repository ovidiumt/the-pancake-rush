using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspendedTrapDamage : MonoBehaviour
{
    public Transform SpykePointDamage;
	public float width;
	public float height;
	public int valoareLovitura = 20;
 	public float rataDeAtac = 2f;
 	float timpulPanaLaUrmatorulAtac = 0f;
 	public LayerMask playerLayer;
 	public Transform player;

 	// void Update()
    //{
    	//if(Time.time >= timpulPanaLaUrmatorulAtac){
				//Ataca();
				//timpulPanaLaUrmatorulAtac = Time.time + 1f / rataDeAtac;
		//}
    //}

    void OnTriggerEnter2D(){
    	player.GetComponent<Player_attack>().esteLovit(valoareLovitura);
    }

    public void Ataca(){

    	Collider2D player = Physics2D.OverlapBox(SpykePointDamage.position, new Vector2(width,height), 0, playerLayer);

		if(player != null){
			player.GetComponent<Player_attack>().esteLovit(valoareLovitura);
		}
    }

     void OnDrawGizmosSelected(){
    	if(SpykePointDamage == null) return;

    	Gizmos.DrawWireCube(SpykePointDamage.position, new Vector3(width,height, 0));
    }
}
