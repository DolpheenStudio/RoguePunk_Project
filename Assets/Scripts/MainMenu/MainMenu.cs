using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject optionsCanvas;

    void Start()
    {
        optionsCanvas.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("StemEncampment", LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Options()
    {
        mainCanvas.SetActive(false);
        optionsCanvas.SetActive(true);
    }

    public void Return()
    {
        mainCanvas.SetActive(true);
        optionsCanvas.SetActive(false);
    }
}
