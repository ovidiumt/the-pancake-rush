using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goblin_hit : MonoBehaviour
{

	public Animator animator;

    //Layers
    public Transform Player;
    public Transform Goblin;
    public AnimationClip animation;

    public Healthbar baraDeViataGoblin;
	public int viataMaxima = 100;
	int viataRamasa;
    // Start is called before the first frame update
    void Start()
    {
        viataRamasa = viataMaxima;
        baraDeViataGoblin.SeteazaViataMaxima(viataMaxima);
        baraDeViataGoblin.gameObject.SetActive(false);
    }

    public void TakeDamage(int lovitura){
         baraDeViataGoblin.gameObject.SetActive(true);

    	viataRamasa -= lovitura;
        baraDeViataGoblin.SeteazaViata(viataRamasa);

    	animator.SetTrigger("esteLovit");

    	if(viataRamasa <= 0){
    		Moarte();
            Destroy (baraDeViataGoblin.gameObject);
            Destroy (gameObject, animation.length); 
    	}
    }

    void Moarte(){

    	//Animatia de moarte
    	animator.SetBool("esteMort",true);
    
    	//Disable inamic
    	Physics2D.IgnoreCollision(Player.GetComponent<CircleCollider2D>(),Goblin.GetComponent<BoxCollider2D>(),true);
    	this.enabled = false;
    }

}
