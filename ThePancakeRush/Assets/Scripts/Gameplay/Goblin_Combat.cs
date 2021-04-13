using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Combat : MonoBehaviour
{

	public Transform attackPoint;
 	public float attackRange = 0.5f;
 	public LayerMask playerLayer;
 	public int attackValue = 40;

 	public float attackRate = 2f;
 	float attackDelay = 0f;
 	public Healthbar goblinHealthbar;
 	public int leftHealth;
 	public int maxHealth = 500;

 	 void Start(){
 		leftHealth = maxHealth;
 		goblinHealthbar.SeteazaViataMaxima(maxHealth);
 	}

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= attackDelay){
        	Attack();
			attackDelay = Time.time + 64f / attackRate;
        }
    }


    void Attack(){

    	//detecteaza inamicii in raza de atac
		Collider2D[] player  =  Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);

		//loveste inamicii
		foreach(Collider2D p in player){
			if(p == null) return;
			p.GetComponent<Player_attack>().esteLovit(attackValue);
		}
    }

    void OnDrawGizmosSelected(){
    	if(attackPoint == null) return;

    	Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
