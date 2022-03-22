using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCanvas : MonoBehaviour
{
    public GameObject inventoryCanvas;
    void Start()
    {
        inventoryCanvas.SetActive(false);
    }

    
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.E) && inventoryCanvas.activeSelf) || IsGamePaused.isGamePaused || IsGamePaused.isPauseMenuOn || IsGamePaused.isSavePointOn || IsGamePaused.isUpgradeCenterOn)
        {
            inventoryCanvas.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.E) && !inventoryCanvas.activeSelf && !IsGamePaused.isGamePaused)
        {
            inventoryCanvas.SetActive(true);
        }
    }
}
