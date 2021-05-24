using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_Menu : MonoBehaviour
{
    public GameObject winMenu;

    // Start is called before the first frame update
    void Start()
    {
        winMenu.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        winMenu.SetActive(true);
    }

    public void Restart()
    {
        winMenu.SetActive(false);
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
