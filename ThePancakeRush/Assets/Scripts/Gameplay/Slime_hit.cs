using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slime_hit : MonoBehaviour
{

	public Animator animator;

    //Layers
    private int Player = 8;
    private int Enemies = 9;
    public AnimationClip animation;

    public Healthbar baraDeViataSlime;
	public int viataMaxima = 100;
	int viataRamasa;
    // Start is called before the first frame update
    void Start()
    {
        viataRamasa = viataMaxima;
        baraDeViataSlime.SeteazaViataMaxima(viataMaxima);
        baraDeViataSlime.gameObject.SetActive(false);
    }

    public void TakeDamage(int lovitura){
         baraDeViataSlime.gameObject.SetActive(true);

    	viataRamasa -= lovitura;
        baraDeViataSlime.SeteazaViata(viataRamasa);

    	animator.SetTrigger("Lovit");

    	if(viataRamasa <= 0){
    		Moarte();
            Destroy (baraDeViataSlime.gameObject);
            Destroy (gameObject, animation.length); 
    	}
    }

    void Moarte(){

    	//Animatia de moarte
    	animator.SetBool("esteMort",true);
    
    	//Disable inamic
    	Physics2D.IgnoreLayerCollision(Player,Enemies,true);
    	this.enabled = false;
    }

}
