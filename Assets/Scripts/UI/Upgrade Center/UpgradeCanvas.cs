using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeCanvas : MonoBehaviour
{
    private Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
    }

    void Update()
    {
        if(gameObject.activeSelf)
        {
            if(IsGamePaused.isGamePaused) canvas.enabled = false;
            else canvas.enabled = true;
        }
    }
}
