using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    private bool deathFlag = false;
  	public GameObject deathMenu;
  	public Transform player;

  	void Start()
    {
  		deathMenu.SetActive(false);
        Time.timeScale = 1f;
  	}

    // Update is called once per frame
    void Update()
    {
       if(player.GetComponent<Player_attack>().getDeathFlag() == true)
        {
       	    deathMenu.SetActive(true);
       	    Time.timeScale = 0f;
       	}
    }

    public void Restart()
    {
        deathMenu.SetActive(false);
    	SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    public void LoadMenu()
    {
    	Time.timeScale = 1f;
    	SceneManager.LoadScene("Menu");
    }
}
