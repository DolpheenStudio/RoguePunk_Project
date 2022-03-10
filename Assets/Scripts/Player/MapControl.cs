using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControl : MonoBehaviour
{
    [SerializeField]
    private GameObject mapCam;

    private bool mapOpen = false;
    
    void Start()
    {
        mapCam.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (mapOpen)
            {
                mapCam.SetActive(false);
                mapOpen = false;
            }
            else
            {
                mapCam.SetActive(true);
                mapOpen = true;
            }
        }
        
    }
}
