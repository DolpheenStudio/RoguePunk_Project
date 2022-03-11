using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    private Player player;
    public GameObject canvas;
    public GameObject saveInfo;
    void Start()
    {
        player = FindObjectOfType<Player>();
        canvas.SetActive(false);
    }
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 1f && !IsGamePaused.isGamePaused)
        {
            canvas.SetActive(true);
            IsGamePaused.isSavePointOn = true;
        }
        else
        {
            canvas.SetActive(false);
            saveInfo.SetActive(false);
            IsGamePaused.isSavePointOn = false;
        }
    }
}
