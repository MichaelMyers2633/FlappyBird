using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic_Manager : MonoBehaviour
{
    public int playerScore;
    public Text score;
    public GameObject gameOverScreen;
    public static bool game_over;

    AudioManager AudioManager;
    private void Awake()
    {
        AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    //calculating players score
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        score.text = playerScore.ToString();
        AudioManager.PlaySFX(AudioManager.points);
    }

    //restarting game after game over screen displays
    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void main_menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    //game over screen after failing
    public void gameOver()
    { 
        gameOverScreen.SetActive(true);
        game_over = true;
    }

    public void quit_game()
    {
        Application.Quit();
    }
}
