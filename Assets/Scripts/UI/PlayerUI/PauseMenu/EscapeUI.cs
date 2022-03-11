using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeUI : MonoBehaviour
{
    public GameObject pauseUI;
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
            Cursor.visible = true;
            IsGamePaused.isGamePaused = true;
        }
        else if(Input.GetButtonDown("Cancel") && pauseUI.activeSelf)
        {
            pauseUI.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = false;
            IsGamePaused.isGamePaused = false;
        }
    }
}
