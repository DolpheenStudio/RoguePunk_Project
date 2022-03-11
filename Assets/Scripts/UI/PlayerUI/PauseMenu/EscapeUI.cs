using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeUI : MonoBehaviour
{
    public GameObject pauseUI;
    public Player player;
    void Start()
    {
        pauseUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetButtonDown("Cancel") && !pauseUI.activeSelf)
        {
            pauseUI.SetActive(true);
            Time.timeScale = 0;
            IsGamePaused.isGamePaused = true;
            IsGamePaused.isPauseMenuOn = true;
        }
        else if(Input.GetButtonDown("Cancel") && pauseUI.activeSelf)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1;
            IsGamePaused.isGamePaused = false;
            IsGamePaused.isPauseMenuOn = false;
        }
    }
}
