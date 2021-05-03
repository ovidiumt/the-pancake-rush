using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public Transform SpykePointDamage;
	public float razaDeAtac = 0.2f;
	public int valoareLovitura = 20;
 	public float rataDeAtac = 2f;
 	float timpulPanaLaUrmatorulAtac = 0f;
 	public LayerMask playerLayer;


 	 void Update()
    {
    	if(Time.time >= timpulPanaLaUrmatorulAtac){
				Ataca();
				timpulPanaLaUrmatorulAtac = Time.time + 1f / rataDeAtac;
		}
    }

    public void Ataca(){

    	Collider2D player = Physics2D.OverlapCircle(SpykePointDamage.position, razaDeAtac, playerLayer);

		if(player != null){
			player.GetComponent<Player_attack>().esteLovit(valoareLovitura);
		}
    }
}
