using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Main_Menu : MonoBehaviour
{
	public GameObject loadingScreen;
	public Slider slider;
	public TextMeshProUGUI progressText;

    public void PlayGame()
    {
	    StartCoroutine(LoadSceneAsyncronously("Game"));
    }

    IEnumerator LoadSceneAsyncronously(string name){
    	AsyncOperation operation = SceneManager.LoadSceneAsync(name);

    	loadingScreen.SetActive(true);

    	while(!operation.isDone){
    		float progress = Mathf.Clamp01(operation.progress / .9f);

    		slider.value = progress;
    		progressText.text = progress * 100f + "%";

    		yield return null;
    	}
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
