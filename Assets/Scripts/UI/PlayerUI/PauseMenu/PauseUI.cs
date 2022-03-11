using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public Player player;

    public void ResumeButton()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
        IsGamePaused.isGamePaused = false;
    }

    public void ReturnButton()
    {
        Time.timeScale = 1;
        IsGamePaused.isGamePaused = false;
        player.Death();
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
