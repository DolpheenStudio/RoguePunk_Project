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
        if(Input.GetKeyDown(KeyCode.E) && inventoryCanvas.activeSelf)
        {
            inventoryCanvas.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.E) && !inventoryCanvas.activeSelf)
        {
            inventoryCanvas.SetActive(true);
        }
    }
}
