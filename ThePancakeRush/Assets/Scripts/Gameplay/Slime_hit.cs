using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_hit : MonoBehaviour
{

	public Animator animator;

    //Layers
    private int Player = 8;
    private int Enemies = 9;
    public AnimationClip animation;

	public int viataMaxima = 100;
	int viataRamasa;
    // Start is called before the first frame update
    void Start()
    {
        viataRamasa = viataMaxima; 
    }

    public void TakeDamage(int lovitura){
    	viataRamasa -= lovitura;

    	animator.SetTrigger("Lovit");

    	if(viataRamasa <= 0){
    		Moarte();
            Destroy (gameObject, animation.length); 
    	}
    }

    void Moarte(){
    	Debug.Log("Inamicul a murit");

    	//Animatia de moarte
    	animator.SetBool("esteMort",true);
    
    	//Disable inamic
    	Physics2D.IgnoreLayerCollision(Player,Enemies,true);
    	this.enabled = false;
    }

}
