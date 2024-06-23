using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public bool isGameOver = false;
    public bool isPaused = false;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject pauseScreen;
    public GameObject birdObject;

    [ContextMenu("Add Score")]
    public void AddScore(int increment)
    {
        score += increment;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        isGameOver = false;
        gameOverScreen.SetActive(isGameOver);
        ResumeGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        isGameOver = true;
        PauseGame();
        gameOverScreen.SetActive(isGameOver);
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;

        if (!isGameOver)
        {
            pauseScreen.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

    public void TogglePause()
    {
        if (isGameOver)
        {
            return;
        }

        if(isPaused)
        {
            ResumeGame();
        } else
        {
            PauseGame();
        }
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu Scene");
    }
}
