using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void SeteazaViataMaxima(int ViataMaxima){
		slider.maxValue = ViataMaxima;
		slider.value = ViataMaxima;

		fill.color = gradient.Evaluate(1f);
	}

    public void SeteazaViata(int Viata){
    	slider.value = Viata;

    	fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
