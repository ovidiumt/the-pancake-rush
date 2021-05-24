using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snake_hit : MonoBehaviour
{
  	public Animator animator;

    //Layers
    public Transform Player;
    public Transform Snake;
    public AnimationClip animation;

    public Healthbar baraDeViataSnake;
	public int viataMaxima = 100;
	int viataRamasa;
    // Start is called before the first frame update
    void Start()
    {
        viataRamasa = viataMaxima;
        baraDeViataSnake.SeteazaViataMaxima(viataMaxima);
        baraDeViataSnake.gameObject.SetActive(false);
    }

    public void TakeDamage(int lovitura){
         baraDeViataSnake.gameObject.SetActive(true);

    	viataRamasa -= lovitura;
        baraDeViataSnake.SeteazaViata(viataRamasa);

    	animator.SetTrigger("esteLovit");

    	if(viataRamasa <= 0){
    		Moarte();
            Destroy (baraDeViataSnake.gameObject);
            Destroy (gameObject, animation.length); 
    	}
    }

    void Moarte(){
    
    	//Disable inamic
    	Physics2D.IgnoreCollision(Player.GetComponent<CircleCollider2D>(),Snake.GetComponent<CircleCollider2D>(),true);
    	this.enabled = false;
    }
}
