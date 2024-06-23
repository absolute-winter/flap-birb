using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogicScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("In-Game Scene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
