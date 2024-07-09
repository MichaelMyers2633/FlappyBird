using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
    public static bool ispaused;
    
    // Start is called before the first frame update
    void Start()
    {
        pausemenu.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        //if(!Logic_Manager.game_over)
        //{
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (ispaused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            }
        //}
       
    }


    public void PauseGame()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
