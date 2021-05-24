using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  
  	public static bool PauseFlag = false;
  	public GameObject pauseMenu;

  	void Start(){
  		pauseMenu.SetActive(false);
  	}

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Escape)){
        	if(PauseFlag) Resume();
        	else Pause();
        }
    }

    public void Resume(){
    	pauseMenu.SetActive(false);
    	Time.timeScale = 1f;
    	PauseFlag = false;
    }

    void Pause(){
    	pauseMenu.SetActive(true);
    	Time.timeScale = 0f;
    	PauseFlag = true;
    }

    public void LoadMenu(){
    	Time.timeScale = 1f;
    	SceneManager.LoadScene("Menu");
    }

    public void QuitGame(){
    	Application.Quit();
    }
}
