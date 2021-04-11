using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird_hit : MonoBehaviour
{
  	public Animator animator;

    //Layers
    private int Player = 8;
    private int Enemies = 10;
    public AnimationClip animation;

    public Healthbar baraDeViataBird;
	public int viataMaxima = 100;
	int viataRamasa;
    // Start is called before the first frame update
    void Start()
    {
        viataRamasa = viataMaxima;
        baraDeViataBird.SeteazaViataMaxima(viataMaxima);
        baraDeViataBird.gameObject.SetActive(false);
    }

    public void TakeDamage(int lovitura){
         baraDeViataBird.gameObject.SetActive(true);

    	viataRamasa -= lovitura;
        baraDeViataBird.SeteazaViata(viataRamasa);

    	if(viataRamasa <= 0){
    		Moarte();
            Destroy (baraDeViataBird.gameObject);
            Destroy (gameObject, animation.length); 
    	}
    }

    void Moarte(){

    	//Disable inamic
    	Physics2D.IgnoreLayerCollision(Player,Enemies,true);
    	this.enabled = false;
    }
}
