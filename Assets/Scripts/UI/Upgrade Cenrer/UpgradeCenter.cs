using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeCenter : MonoBehaviour
{
    private Player player;
    public GameObject canvas;
    void Start()
    {
        player = FindObjectOfType<Player>();
        canvas.SetActive(false);
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 1.5 && !IsGamePaused.isGamePaused) 
        {
            canvas.SetActive(true);
            IsGamePaused.isUpgradeCenterOn = true;
        }
        else
        {
            canvas.SetActive(false);
            IsGamePaused.isUpgradeCenterOn = false;
        }
    }
}
