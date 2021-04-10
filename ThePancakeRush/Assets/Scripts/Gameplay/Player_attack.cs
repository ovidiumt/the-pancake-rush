using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour
{
 	public Animator animator;

 	public Transform punctDeAtac;
 	public float razaDeAtac = 0.5f;
 	public LayerMask feluriDeInamici;

 	public int valoareLovitura = 40;

 	public float rataDeAtac = 2f;
 	float timpulPanaLaUrmatorulAtac = 0f;
 	public Healthbar baraDeViata;
 	public int viataRamasa;
 	public int viataMaxima = 500;

 	void Start(){
 		viataRamasa = viataMaxima;
 		baraDeViata.SeteazaViataMaxima(viataMaxima);
 	}


    // Update is called once per frame
    void Update()
    {
    	if(Time.time >= timpulPanaLaUrmatorulAtac){
			if(Input.GetKeyDown(KeyCode.S)){
				Attack();
				timpulPanaLaUrmatorulAtac = Time.time + 2f / rataDeAtac;
			}        
		}

		if(Input.GetKeyDown(KeyCode.Q)){
			esteLovit(20);
		}
    }

    void esteLovit(int valoareLovitura){
    	viataRamasa -= valoareLovitura;
    	baraDeViata.SeteazaViata(viataRamasa);
    }

    void Attack(){
    	//porneste animatia cand este apasat butonul
    	animator.SetTrigger("Attack");

    	//detecteaza inamicii in raza de atac
		Collider2D[] inamiciLoviti  =  Physics2D.OverlapCircleAll(punctDeAtac.position, razaDeAtac, feluriDeInamici);

		//loveste inamicii
		foreach(Collider2D inamic in inamiciLoviti) inamic.GetComponent<Slime_hit>().TakeDamage(valoareLovitura);
    }

    void OnDrawGizmosSelected(){
    	if(punctDeAtac == null) return;

    	Gizmos.DrawWireSphere(punctDeAtac.position, razaDeAtac);
    }
}
