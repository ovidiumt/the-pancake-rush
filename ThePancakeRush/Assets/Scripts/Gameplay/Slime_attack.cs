using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_attack : MonoBehaviour
{
	
	public Transform punctDeAtacSlime;
	public float razaDeAtac = 0.5f;
	public int valoareLovitura = 20;
 	public float rataDeAtac = 4f;
 	float timpulPanaLaUrmatorulAtac = 0f;
 	public LayerMask playerLayer;


 	 void Update()
    {
    	if(Time.time >= timpulPanaLaUrmatorulAtac){
				Ataca();
				timpulPanaLaUrmatorulAtac = Time.time + 2f / rataDeAtac;
		}
    }

    public void Ataca(){

    	Collider2D player = Physics2D.OverlapCircle(punctDeAtacSlime.position, razaDeAtac, playerLayer);

		if(player != null){
			player.GetComponent<Player_attack>().esteLovit(valoareLovitura);
		}
    }

    void OnDrawGizmosSelected(){
    	if(punctDeAtacSlime == null) return;

    	Gizmos.DrawWireSphere(punctDeAtacSlime.position, razaDeAtac);
    }
}
