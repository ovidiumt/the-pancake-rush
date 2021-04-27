using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Player_attack : MonoBehaviour
{
 	public Animator animator;
 	public AnimationClip animation;
 	private int Player = 8;
    private int Enemies = 10;

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

    }

    public void esteLovit(int valoareLovitura){
    	viataRamasa -= valoareLovitura;
    	baraDeViata.SeteazaViata(viataRamasa);

    	animator.SetTrigger("esteLovit");

    	if(viataRamasa <= 0){
    		Moarte();
            Destroy (gameObject, animation.length); 
    	}
    }

    public void setLife(int value){
        if(viataRamasa + value < viataMaxima){
            viataRamasa += value;
            baraDeViata.SeteazaViata(viataRamasa);
        }else{
            viataRamasa = viataMaxima;
            baraDeViata.SeteazaViata(viataRamasa);
        }
    }

    void Moarte(){
    	//Animatia de moarte
    	animator.SetBool("esteMort",true);
    
    	//Disable inamic
    	Physics2D.IgnoreLayerCollision(Enemies,Player,true);
    	this.enabled = false;
    }


    void Attack(){
    	//porneste animatia cand este apasat butonul
    	animator.SetTrigger("Attack");

    	//detecteaza inamicii in raza de atac
		Collider2D[] inamiciLoviti  =  Physics2D.OverlapCircleAll(punctDeAtac.position, razaDeAtac, feluriDeInamici);

		//loveste inamicii
		foreach(Collider2D inamic in inamiciLoviti){
			if(inamic.gameObject.name == "Slime") inamic.GetComponent<Slime_hit>().TakeDamage(valoareLovitura);
			else if(inamic.gameObject.name == "Goblin") inamic.GetComponent<Goblin_hit>().TakeDamage(valoareLovitura);
			else if(inamic.gameObject.name == "Snake") inamic.GetComponent<Snake_hit>().TakeDamage(valoareLovitura);
			else if(inamic.gameObject.name == "Bomber") inamic.GetComponent<Bomber_hit>().TakeDamage(valoareLovitura);
			else if(inamic.gameObject.name == "Bird") inamic.GetComponent<Bird_hit>().TakeDamage(valoareLovitura);
		}
    }

    void OnDrawGizmosSelected(){
    	if(punctDeAtac == null) return;

    	Gizmos.DrawWireSphere(punctDeAtac.position, razaDeAtac);
    }
}
