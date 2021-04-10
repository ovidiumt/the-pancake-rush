using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_hit : MonoBehaviour
{

	public Animator animator;

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
    	}
    }

    void Moarte(){
    	Debug.Log("Inamicul a murit");

    	//Animatia de moarte
    	animator.SetBool("esteMort",true);
    
    	//Disable inamic
    	GetComponent<Collider2D>().enabled = false;
    	this.enabled = false;
    }

}
